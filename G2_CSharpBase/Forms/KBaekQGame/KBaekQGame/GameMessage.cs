using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBaekQGame
{
    /* Games message class that shows the messages based on the
     * type of the events which is as follows
     * 0: successful
     * 1: warning
     * 2: error
     */
    class GameMessage
    {
        #region Fields
        const string MESSAGE_TITLE = "Q Game";
        #endregion
        #region Properties
        public string Message { get; set; }        
        public int Type { get; set; }
        #endregion

        #region Constructors
        public GameMessage() {}
        #endregion

        #region Methods
        /// <summary>
        /// Shows status message based on the type
        /// </summary>
        /// <param name="type"></param>
        /// <param name="message"></param>
        public static void ShowMessage(int type, string message)
        {
            switch (type)
            {
                case 1:
                    MessageBox.Show(message, MESSAGE_TITLE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                    break;
                case 2:
                    MessageBox.Show(message, MESSAGE_TITLE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                    break;
                default:
                    MessageBox.Show(message, MESSAGE_TITLE,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    break;                    
            }
        }
        #endregion
    }
}
