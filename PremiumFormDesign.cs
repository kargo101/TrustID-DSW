using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace user_dashboard
{
    internal static class PremiumFormDesign
    {
        public static bool DarkMode { get; private set; } = true;

        private static readonly Color DarkBase = Color.FromArgb(3, 14, 29);
        private static readonly Color DarkSidebar = Color.FromArgb(3, 13, 26);
        private static readonly Color DarkCard = Color.FromArgb(6, 25, 46);
        private static readonly Color DarkInput = Color.FromArgb(9, 31, 55);
        private static readonly Color DarkBorder = Color.FromArgb(31, 93, 137);

        private static readonly Color LightBase = Color.FromArgb(247, 251, 255);
        private static readonly Color LightSidebar = Color.FromArgb(244, 249, 253);
        private static readonly Color LightCard = Color.FromArgb(250, 253, 255);
        private static readonly Color LightInput = Color.White;
        private static readonly Color LightBorder = Color.FromArgb(181, 208, 227);

        private static readonly Color Blue = Color.FromArgb(21, 119, 235);
        private static readonly Color Cyan = Color.FromArgb(35, 203, 240);
        private static readonly Color DarkText = Color.FromArgb(245, 249, 255);
        private static readonly Color LightText = Color.FromArgb(12, 29, 52);
        private static readonly Color DarkMuted = Color.FromArgb(168, 192, 220);
        private static readonly Color LightMuted = Color.FromArgb(82, 106, 133);

        public static void Apply(Control root, string screen)
        {
            root.SuspendLayout();
            ApplyBackground(root, screen);
            StyleControls(root);
            Arrange(root, screen);
            root.ResumeLayout(true);
        }

        public static void ApplyDashboardShell(Form form)
        {
            Panel? sidebar = Find<Panel>(form, "pnlSidebar");
            Panel? header = Find<Panel>(form, "pnlHeader");
            Panel? content = Find<Panel>(form, "pnlContent");
            Label? title = Find<Label>(form, "lblPageTitle");
            Label? subtitle = Find<Label>(form, "lblPageSubtitle");

            form.BackColor = DarkMode ? DarkBase : LightBase;

            if (sidebar != null)
            {
                sidebar.BackColor = DarkMode ? DarkSidebar : LightSidebar;
                sidebar.BorderStyle = BorderStyle.None;
            }

            if (header != null)
            {
                header.BackColor = DarkMode ? DarkBase : LightBase;
                header.BorderStyle = BorderStyle.None;
            }

            if (content != null)
                content.BackColor = DarkMode ? DarkBase : LightBase;

            if (title != null)
            {
                title.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
                title.ForeColor = DarkMode ? DarkText : LightText;
                title.Location = new Point(24, 8);
            }

            if (subtitle != null)
            {
                subtitle.AutoSize = false;
                subtitle.Size = new Size(900, 22);
                subtitle.Location = new Point(24, 45);
                subtitle.ForeColor = DarkMode ? DarkMuted : LightMuted;
                subtitle.AutoEllipsis = true;
            }

            string[] names =
            {
                "btnDashboard", "btnProfile", "btnVerification", "btnQualifications",
                "btnSearchUsers", "btnTransactions", "btnTrustScore", "btnReviews",
                "btnSettings", "btnLogout"
            };

            foreach (string name in names)
            {
                Button? button = Find<Button>(form, name);
                if (button != null)
                    StyleNavigationButton(button, name == "btnDashboard");
            }

            AddDashboardThemeButton(form, sidebar, content);
        }

        public static void SetActiveNav(Form form, Button activeButton)
        {
            string[] names =
            {
                "btnDashboard", "btnProfile", "btnVerification", "btnQualifications",
                "btnSearchUsers", "btnTransactions", "btnTrustScore", "btnReviews",
                "btnSettings", "btnLogout"
            };

            foreach (string name in names)
            {
                Button? button = Find<Button>(form, name);
                if (button != null)
                    StyleNavigationButton(button, button == activeButton);
            }
        }

        public static void AddFormThemeToggle(Form form, string screen)
        {
            Button? toggle = form.Controls.Find("btnPremiumTheme", true).FirstOrDefault() as Button;

            if (toggle == null)
            {
                toggle = new Button();
                toggle.Name = "btnPremiumTheme";
                toggle.Size = new Size(135, 32);
                toggle.Location = new Point(18, form.ClientSize.Height - 47);
                toggle.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
                toggle.Click += (sender, e) =>
                {
                    DarkMode = !DarkMode;
                    Apply(form, screen);
                    AddFormThemeToggle(form, screen);
                };
                form.Controls.Add(toggle);
                toggle.BringToFront();
            }

            StyleThemeButton(toggle);
        }

        private static void AddDashboardThemeButton(Form form, Panel? sidebar, Panel? content)
        {
            if (sidebar == null)
                return;

            Button? toggle = sidebar.Controls.Find("btnPremiumTheme", true).FirstOrDefault() as Button;

            if (toggle == null)
            {
                toggle = new Button();
                toggle.Name = "btnPremiumTheme";
                toggle.Size = new Size(145, 34);
                toggle.Location = new Point(10, sidebar.Height - 54);
                toggle.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
                toggle.Click += (sender, e) =>
                {
                    DarkMode = !DarkMode;
                    ApplyDashboardShell(form);

                    if (content != null)
                    {
                        foreach (Control child in content.Controls)
                            Apply(child, GetScreenName(child));
                    }
                };
                sidebar.Controls.Add(toggle);
            }

            StyleThemeButton(toggle);
        }

        private static void StyleThemeButton(Button button)
        {
            button.Text = DarkMode ? "☾  Dark Mode" : "☀  Light Mode";
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 1;
            button.FlatAppearance.BorderColor = DarkMode ? DarkBorder : LightBorder;
            button.BackColor = DarkMode ? DarkCard : Color.White;
            button.ForeColor = DarkMode ? DarkText : LightText;
            button.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        }

        private static string GetScreenName(Control control)
        {
            string name = control.GetType().Name;

            if (name.Contains("Dashboard")) return "Dashboard";
            if (name.Contains("Profile")) return "Profile";
            if (name.Contains("Verification")) return "Verification";
            if (name.Contains("Qualification")) return "Qualifications";
            if (name.Contains("SearchRegistry")) return "Registry";
            if (name.Contains("Transaction")) return "Transactions";
            if (name.Contains("TrustScore")) return "TrustScore";
            if (name.Contains("Review")) return "Reviews";
            if (name.Contains("Setting")) return "Settings";

            return "General";
        }

        private static void ApplyBackground(Control root, string screen)
        {
            string mode = DarkMode ? "Dark" : "Light";
            string path = Path.Combine(
                Application.StartupPath,
                "Resources",
                "PremiumForm",
                screen + "_" + mode + ".png"
            );

            if (File.Exists(path))
            {
                using Image source = Image.FromFile(path);
                root.BackgroundImage = new Bitmap(source);
                root.BackgroundImageLayout = ImageLayout.Stretch;
            }

            root.BackColor = DarkMode ? DarkBase : LightBase;
            root.ForeColor = DarkMode ? DarkText : LightText;
        }

        private static void StyleControls(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control.Name == "btnPremiumTheme")
                    continue;

                if (control is Panel panel)
                    StylePanel(panel);
                else if (control is TextBox textBox)
                    StyleTextBox(textBox);
                else if (control is ComboBox comboBox)
                    StyleComboBox(comboBox);
                else if (control is Button button)
                    StyleButton(button);
                else if (control is Label label)
                    StyleLabel(label);
                else if (control is LinkLabel linkLabel)
                    StyleLink(linkLabel);
                else if (control is CheckBox checkBox)
                    StyleCheckBox(checkBox);
                else if (control is RadioButton radioButton)
                    StyleRadioButton(radioButton);
                else if (control is ListBox listBox)
                    StyleListBox(listBox);
                else if (control is ListView listView)
                    StyleListView(listView);
                else if (control is DataGridView grid)
                    StyleGrid(grid);
                else if (control is NumericUpDown numeric)
                    StyleNumeric(numeric);

                if (control.HasChildren)
                    StyleControls(control);
            }
        }

        private static void StylePanel(Panel panel)
        {
            string name = panel.Name;

            bool transparent =
                name == "pnlLogin" ||
                name == "pnlCreateAccount" ||
                name == "pnlDashboardHeader" ||
                name == "pnlStats" ||
                name == "pnlQuickActions" ||
                name == "pnlHeader" ||
                name.EndsWith("Content");

            if (transparent)
            {
                panel.BackColor = Color.Transparent;
                panel.BorderStyle = BorderStyle.None;
                return;
            }

            panel.BackColor = DarkMode ? DarkCard : LightCard;
            panel.BorderStyle = BorderStyle.FixedSingle;
        }

        private static void StyleTextBox(TextBox textBox)
        {
            textBox.BackColor = DarkMode ? DarkInput : LightInput;
            textBox.ForeColor = DarkMode ? DarkText : LightText;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
        }

        private static void StyleComboBox(ComboBox comboBox)
        {
            comboBox.BackColor = DarkMode ? DarkInput : LightInput;
            comboBox.ForeColor = DarkMode ? DarkText : LightText;
            comboBox.FlatStyle = FlatStyle.Flat;
            comboBox.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
        }

        private static void StyleButton(Button button)
        {
            string name = button.Name.ToLowerInvariant();

            bool primary =
                name.Contains("login") ||
                name.Contains("submit") ||
                name.Contains("save") ||
                name.Contains("upload") ||
                name.Contains("update") ||
                name.Contains("create") ||
                name.Contains("write") ||
                name.Contains("enteramount") ||
                name.Contains("approve");

            bool danger =
                name.Contains("delete") ||
                name.Contains("reject") ||
                name.Contains("suspend") ||
                name.Contains("clear") ||
                name.Contains("logout");

            button.FlatStyle = FlatStyle.Flat;
            button.Cursor = Cursors.Hand;
            button.Font = new Font("Segoe UI", Math.Max(9F, button.Font.Size), button.Font.Style);

            if (danger)
            {
                button.FlatAppearance.BorderSize = 1;
                button.FlatAppearance.BorderColor = Color.FromArgb(150, 72, 88);
                button.BackColor = DarkMode
                    ? Color.FromArgb(58, 28, 39)
                    : Color.FromArgb(255, 241, 244);
                button.ForeColor = DarkMode
                    ? Color.FromArgb(255, 214, 222)
                    : Color.FromArgb(137, 44, 64);
            }
            else if (primary)
            {
                button.FlatAppearance.BorderSize = 0;
                button.BackColor = Blue;
                button.ForeColor = Color.White;
                button.Font = new Font("Segoe UI", Math.Max(9F, button.Font.Size), FontStyle.Bold);
            }
            else
            {
                button.FlatAppearance.BorderSize = 1;
                button.FlatAppearance.BorderColor = DarkMode ? DarkBorder : LightBorder;
                button.BackColor = DarkMode ? DarkCard : Color.White;
                button.ForeColor = DarkMode ? DarkText : LightText;
            }

            button.FlatAppearance.MouseOverBackColor = DarkMode
                ? Color.FromArgb(12, 45, 75)
                : Color.FromArgb(235, 247, 254);

            button.FlatAppearance.MouseDownBackColor = DarkMode
                ? Color.FromArgb(15, 56, 91)
                : Color.FromArgb(223, 240, 251);
        }

        private static void StyleLabel(Label label)
        {
            label.BackColor = Color.Transparent;

            bool heading = label.Font.Bold || label.Font.Size >= 11F;

            label.ForeColor = heading
                ? (DarkMode ? DarkText : LightText)
                : (DarkMode ? DarkMuted : LightMuted);
        }

        private static void StyleLink(LinkLabel linkLabel)
        {
            linkLabel.BackColor = Color.Transparent;
            linkLabel.LinkColor = DarkMode ? Cyan : Blue;
            linkLabel.ActiveLinkColor = Cyan;
            linkLabel.VisitedLinkColor = linkLabel.LinkColor;
        }

        private static void StyleCheckBox(CheckBox checkBox)
        {
            checkBox.BackColor = Color.Transparent;
            checkBox.ForeColor = DarkMode ? DarkText : LightText;
            checkBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular);
        }

        private static void StyleRadioButton(RadioButton radioButton)
        {
            radioButton.BackColor = Color.Transparent;
            radioButton.ForeColor = DarkMode ? DarkText : LightText;
        }

        private static void StyleListBox(ListBox listBox)
        {
            listBox.BackColor = DarkMode ? DarkInput : LightInput;
            listBox.ForeColor = DarkMode ? DarkText : LightText;
            listBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private static void StyleListView(ListView listView)
        {
            listView.BackColor = DarkMode ? DarkInput : LightInput;
            listView.ForeColor = DarkMode ? DarkText : LightText;
            listView.BorderStyle = BorderStyle.FixedSingle;
        }

        private static void StyleNumeric(NumericUpDown numeric)
        {
            numeric.BackColor = DarkMode ? DarkInput : LightInput;
            numeric.ForeColor = DarkMode ? DarkText : LightText;
            numeric.BorderStyle = BorderStyle.FixedSingle;
        }

        private static void StyleGrid(DataGridView grid)
        {
            grid.EnableHeadersVisualStyles = false;
            grid.BorderStyle = BorderStyle.None;
            grid.RowHeadersVisible = false;
            grid.BackgroundColor = DarkMode ? DarkCard : LightCard;
            grid.GridColor = DarkMode ? DarkBorder : LightBorder;

            grid.ColumnHeadersDefaultCellStyle.BackColor = DarkMode
                ? Color.FromArgb(8, 31, 53)
                : Color.FromArgb(232, 244, 251);

            grid.ColumnHeadersDefaultCellStyle.ForeColor = DarkMode ? DarkText : LightText;
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                grid.ColumnHeadersDefaultCellStyle.BackColor;

            grid.DefaultCellStyle.BackColor = DarkMode ? DarkCard : Color.White;
            grid.DefaultCellStyle.ForeColor = DarkMode ? DarkText : LightText;
            grid.DefaultCellStyle.SelectionBackColor = Blue;
            grid.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        private static void StyleNavigationButton(Button button, bool active)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.TextAlign = ContentAlignment.MiddleLeft;
            button.Padding = new Padding(12, 0, 0, 0);
            button.Size = new Size(150, 32);
            button.Font = new Font("Segoe UI", 9.5F, active ? FontStyle.Bold : FontStyle.Regular);

            button.BackColor = active
                ? (DarkMode ? Color.FromArgb(7, 54, 89) : Color.FromArgb(224, 242, 253))
                : (DarkMode ? DarkSidebar : LightSidebar);

            button.ForeColor = active
                ? (DarkMode ? Cyan : Blue)
                : (DarkMode ? DarkText : LightText);
        }

        private static T? Find<T>(Control root, string name) where T : Control
        {
            Control[] found = root.Controls.Find(name, true);

            if (found.Length == 0)
                return null;

            return found[0] as T;
        }

        private static void Put(Control root, string name, int x, int y, int width, int height)
        {
            Control? control = Find<Control>(root, name);

            if (control == null)
                return;

            control.Location = new Point(x, y);
            control.Size = new Size(width, height);
        }

        private static void Arrange(Control root, string screen)
        {
            if (screen == "Login")
            {
                Put(root, "pnlLogin", 58, 82, 405, 405);

                Panel? panel = Find<Panel>(root, "pnlLogin");

                if (panel != null)
                {
                    panel.BackColor = Color.Transparent;
                    panel.BorderStyle = BorderStyle.None;

                    Put(panel, "lblTrustIdMotto", 38, 38, 320, 36);
                    Put(panel, "lblLoginSubtitle", 38, 80, 325, 36);
                    Put(panel, "lblUsername", 38, 128, 310, 20);
                    Put(panel, "txtName", 38, 151, 310, 29);
                    Put(panel, "lblPassword", 38, 195, 310, 20);
                    Put(panel, "txtPassword", 38, 218, 310, 29);
                    Put(panel, "chkShowPassword", 38, 258, 135, 23);
                    Put(panel, "lnkForgotPassword", 218, 258, 130, 23);
                    Put(panel, "btnLogin", 38, 292, 310, 35);
                    Put(panel, "lblNoAccount", 58, 344, 160, 20);
                    Put(panel, "lnkCreateAccount", 218, 344, 130, 20);
                }
            }
            else if (screen == "CreateAccount")
            {
                Put(root, "pnlCreateAccount", 45, 82, 450, 370);

                Panel? panel = Find<Panel>(root, "pnlCreateAccount");

                if (panel != null)
                {
                    panel.BackColor = Color.Transparent;
                    panel.BorderStyle = BorderStyle.None;
                    Put(panel, "chkCreateShowPasswords", 128, 247, 150, 23);
                    Put(panel, "btnCreateAccount", 128, 282, 249, 32);
                }
            }
        }
    }
}
