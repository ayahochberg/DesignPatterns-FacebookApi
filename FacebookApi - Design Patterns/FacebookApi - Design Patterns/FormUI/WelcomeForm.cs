using FacebookWrapper;
using System;
using System.Windows.Forms;
using FormsUI.FacebookAppLogic;

namespace FormsUI
{
    public partial class WelcomeForm : Form
    {
        public static readonly string sr_AccessTokenFilePath = String.Format(@"{0}\ApplicationSettingsFile.xml", Application.StartupPath);
        private MainFormFacade m_MainFormFacade = MainFormFacade.GetInstance();

        public WelcomeForm()
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 200;
            FacebookService.s_FbApiVersion = 2.8f;
            MainForm.s_AppSettings = AppSettings.LoadFromFile();
        }

        protected override void OnShown(EventArgs e)
        {
            loginAutomaticIfUserRememberd();
        }

        private void logInButton_OnClick(object sender, EventArgs e)
        {
            loginManualy();
        }

        private void loginAutomaticIfUserRememberd()
        {
            this.Hide();
            LoginResult loginResult = login(false);
            if (loginResult == null)
            {
                this.Show();
            }
        }

        private void loginManualy()
        {
            LoginResult loginResult = login(true);
            if(loginResult == null)
            {
                MessageBox.Show(Utils.k_LoginProblemMessage);
            }
        }

        private LoginResult login(bool i_IsManulyLogIn)
        {
            LoginResult loginResult = null;
            try
            {
                loginResult = FacebookLogin.Login(i_IsManulyLogIn);
            }
            catch (Exception e)
            {
                string message = String.Format(Utils.k_LoginProblemMessage +"{0}: {1}","Exception Details",e.Message);
                MessageBox.Show(message);
            }
            if (loginResult != null)
            {
                m_MainFormFacade.m_LoginUser = loginResult.LoggedInUser;
                openMainForm(loginResult);
            }

            return loginResult;
        }

        private void openMainForm(LoginResult i_LoginResult)
        {
            updateAppSetings(i_LoginResult);
            MessageBox.Show(String.Format(Utils.k_WelcomeMessage, m_MainFormFacade.m_LoginUser.Name));
            MainForm formMain = MainForm.GetInstance();
            formMain.Show();
            this.Hide();
        }

        private void updateAppSetings(LoginResult i_LoginResult)
        {
            if (rememberMeCheckBox.Checked || MainForm.s_AppSettings.RememberUser)
            {
                MainForm.s_AppSettings.LastAccessToken = i_LoginResult.AccessToken;
                MainForm.s_AppSettings.RememberUser = true;
            }
        }
    }
}