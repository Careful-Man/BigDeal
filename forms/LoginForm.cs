namespace BigDeal {
	public partial class LoginForm : Form {
		public LoginForm() {
			InitializeComponent();
		}

		private void buttonLogin_Click(object sender, EventArgs e) {
			this.Visible = false;
			new forms.MainForm().ShowDialog();
			this.Close();
		}
    }
}