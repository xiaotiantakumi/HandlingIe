using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using SHDocVw;

namespace HandlingIe
{
    /// <summary>
    /// SHDocVw.InternetExplorerをラップするためのクラス
    /// </summary>
    class IeManager : IDisposable
    {
        /// <summary>
        /// このクラスのGUIDを念のため用意
        /// </summary>
        public Guid Guid { get; }

        /// <summary>
        /// 親が閉じられているか
        /// </summary>
        public bool IsParentClosed { get; private set; } = false;

        /// <summary>
        /// 親から開かれた子IEのリスト
        /// </summary>
        private List<InternetExplorer> _childExplorers = new List<InternetExplorer>();

        private InternetExplorer _parentIe;

        /// <summary>
        /// SHDocVw.InternetExplorerをラップするためのクラス
        /// </summary>
        /// <param name="navUrl"></param>
        public IeManager(string navUrl)
        {
            Guid = Guid.NewGuid();
            _parentIe = new InternetExplorer();
            try
            {
                _parentIe.Navigate(navUrl);
                _parentIe.Visible = true;
                // 新しくIEを開くタイミングで発生するイベントにアタッチ
                _parentIe.NewWindow3 += IeOn_NewWindow3;
                _parentIe.OnQuit += IeOn_OnQuit;
            }
            catch (Exception e)
            {
                Marshal.ReleaseComObject(_parentIe);
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// リソースを解放
        /// </summary>
        public void Dispose()
        {
            CloseParentIe();

            CloseAllChildIe();
        }
        /// <summary>
        /// 最後に開いたブラウザを閉じる
        /// </summary>
        public void CloseLastChildIe()
        {
            // 子の解放
            if (_childExplorers != null && _childExplorers.Any())
            {
                try
                {
                    var ie = _childExplorers.Last();
                    ie.Quit();
                    ie.NewWindow3 -= IeOn_NewWindow3;
                    _childExplorers.Remove(ie);
                    // リソースを解放
                    Marshal.ReleaseComObject(ie);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            }
        }
        /// <summary>
        /// すべての子を閉じる
        /// </summary>
        private void CloseAllChildIe()
        {
            // 子の解放
            if (_childExplorers != null && _childExplorers.Any())
            {
                foreach (var ie in _childExplorers)
                {
                    try
                    {
                        ie.Quit();
                        ie.NewWindow3 -= IeOn_NewWindow3;
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                    }
                    finally
                    {
                        // リソースを解放
                        Marshal.ReleaseComObject(ie);
                    }
                }

                _childExplorers = null;
            }
        }
        /// <summary>
        /// 親を閉じる
        /// </summary>
        private void CloseParentIe()
        {
            // 親の解放
            try
            {
                if (_parentIe != null)
                {
                    if(!IsParentClosed)_parentIe.Quit();
                    IsParentClosed = true;
                    _parentIe.NewWindow3 -= IeOn_NewWindow3;
                    _parentIe.OnQuit -= IeOn_OnQuit;
                    // リソースを解放
                    Marshal.ReleaseComObject(_parentIe);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }
        }

        public Action onQuitParentAction;
        /// <summary>
		/// 親が閉じられた場合は、そのステータスを保持する
		/// </summary>
		private void IeOn_OnQuit()
        {
            IsParentClosed = true;
            onQuitParentAction?.Invoke();
        }

        /// <summary>
        /// ie右クリックのタブを新しくor新しいwindowで開く場合に発生するイベント。COMの管理下におく
        /// </summary>
        /// <param name="ppdisp"></param>
        /// <param name="cancel"></param>
        /// <param name="dwflags"></param>
        /// <param name="bstrurlcontext"></param>
        /// <param name="bstrurl"></param>
        private void IeOn_NewWindow3(ref object ppdisp, ref bool cancel, uint dwflags, string bstrurlcontext, string bstrurl)
        {
            Type comType = Type.GetTypeFromProgID("InternetExplorer.Application");
            InternetExplorer ie = Activator.CreateInstance(comType) as InternetExplorer;
            _childExplorers.Add(ie);
            ie.RegisterAsBrowser = true;
            ie.NewWindow3 += IeOn_NewWindow3;
            ppdisp = ie.Application;
            ie.Visible = true;
        }


    }
}