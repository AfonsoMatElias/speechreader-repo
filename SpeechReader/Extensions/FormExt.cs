using System.Drawing;
using System.Windows.Forms;

namespace SpeechReader
{
    public static class FormExt
    {

        static Color main_color = Color.FromArgb(47, 47, 50);
        static Color main_lighter_color = Color.FromArgb(45, 45, 48);
        static Color top_bar_color = Color.FromArgb(40, 40, 43);

        public static bool BlackTheme(this Form form, PictureBox btn)
        {

            btn.Image = global::SpeechReader.Properties.Resources.cog_min_ligth;

            

            foreach (var c in form.Controls)
            {
                ApplyChanges((Control)c);
            }

            return true;

        }

        public static void ApplyChanges(Control c)
        {
            if (c is Panel)
            {
                var obj = c as Panel;
                if (obj.Name == "TopBarPanel")
                    obj.BackColor = top_bar_color;
                else if (obj.Name != "BottomPanel")
                    obj.BackColor = main_color;

                foreach (var cc in c.Controls)
                {
                    ApplyChanges((Control)cc);
                }
            }
            else
            {

                if (c is Label)
                    (c as Label).ForeColor = Color.White;

                if (c is Button)
                    (c as Button).ForeColor = Color.White;

                if (c is TrackBar)
                    (c as TrackBar).BackColor = main_color;

                if (c is TextBox)
                {
                    (c as TextBox).ForeColor = Color.White;
                    (c as TextBox).BackColor = main_lighter_color;

                }

                if (c is MaskedTextBox)
                {
                    (c as MaskedTextBox).ForeColor = Color.White;
                    (c as MaskedTextBox).BackColor = main_lighter_color;

                }

                if (c is ComboBox)
                {
                    (c as ComboBox).BackColor = main_lighter_color;
                    (c as ComboBox).ForeColor = Color.White;
                }
            }
        }


    }
}
