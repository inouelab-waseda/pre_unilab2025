using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;

namespace unilab2025
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        #region Main関数
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Title());
        }
        #endregion

        #region フォーム呼び出し
        public static partial class Func
        {

            public static void CreatePrologue(Form currentForm)
            {
                CurrentFormState.FormName = "Prologue";
                CurrentFormState.StateData.Clear();

                Prologue form = new Prologue();
                form.Show();
                if (!(currentForm is Title))
                {
                    currentForm.Dispose();
                }
            }
        }
        #endregion

        #region 進行状況管理
        public partial class CurrentFormState
        {
            public static string FormName = "Prologue";
            public static Dictionary<string, object> StateData = new Dictionary<string, object>();
        }
        #endregion
    }
}
