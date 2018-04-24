using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videoteka {
    public class TemplatedForm : Form {

        public int currentPage = 0;
        public string defaultText = "";
        public Control mainPanel = null;
        int width = 484;
        int maxHeight = 1200;
        int minHeight = 520;

        // Initialization
        protected virtual void InitializeTemplatedForm() {
            Paint += OnPaint;
            Resize += OnResize;
            defaultText = Text;
        }


        // Events
        void OnPaint(object sender, PaintEventArgs e) {
            DrawDividers(e.Graphics);
        }

        void OnResize(object sender, EventArgs e) {
            Refresh();
        }


        // Methods
        protected void DrawDividers(Graphics g) {
            if (mainPanel == null) return;
            Pen pen = new Pen(Color.Gray, 1);

            var x1 = new Point(mainPanel.Location.X, mainPanel.Location.Y - 1);
            var x2 = new Point(mainPanel.Location.X + mainPanel.Width, mainPanel.Location.Y - 1);
            var x3 = new Point(mainPanel.Location.X, mainPanel.Location.Y + mainPanel.Height);
            var x4 = new Point(mainPanel.Location.X + mainPanel.Width, mainPanel.Location.Y + mainPanel.Height);
            g.DrawLine(pen, x1, x2);
            g.DrawLine(pen, x3, x4);

            g.Dispose();
        }

        protected void CreateControlsFromTemplate(Control template, Control panel, string name, Control[] controls, int numControls) {
            var offset = template.Location.Y + template.Height;

            for (int i = 0; i < numControls; i++) {
                var controlGroup = CopyProperties(template, new GroupBox());
                controlGroup.Location = new Point(template.Location.X, offset * i + template.Location.Y);
                controlGroup.Name = name + i;
                controlGroup.Text = name + " " + i;

                foreach (Control control in template.Controls) {
                    Control newControl = CopyProperties(control, (Control)Activator.CreateInstance(control.GetType())); ;

                    if (newControl != null) {
                        controlGroup.Controls.Add(newControl);
                    }
                }

                //controlGroup.Hide();
                controls[i] = controlGroup;
                panel.Controls.Add(controlGroup);
            }

            panel.Controls.Remove(template);
            template.Dispose();

            panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;

            MaximumSize = new Size(width, maxHeight);
            MinimumSize = new Size(width, minHeight);

            mainPanel = panel;
        }

        Control CopyProperties(Control source, Control dest) {
            dest.Text = source.Text;
            dest.Width = source.Width;
            dest.Height = source.Height;
            dest.Location = source.Location;
            dest.Name = source.Name;
            dest.MaximumSize = source.MaximumSize;
            dest.MinimumSize = source.MinimumSize;
            dest.TabIndex = source.TabIndex;
            dest.AutoSize = source.AutoSize;
            dest.Font = source.Font;

            return dest;
        }

        protected void UpdatePagination(int total, int perPage, Control prev, Control next, Control label) {
            var pageCount = total / perPage + (total % perPage > 0 ? 1 : 0);

            if (currentPage >= pageCount || currentPage < 0) {
                currentPage = 0;
            }

            var offset = currentPage * perPage;

            if (total > 0) {
                var rangeStart = offset + 1;
                var rangeEnd = Math.Min(offset + perPage, total);
                label.Text = rangeStart + " - " + rangeEnd + " / " + total;
            }
            else {
                label.Text = "";
            }

            prev.Enabled = currentPage > 0;
            next.Enabled = currentPage < (pageCount - 1);
        }
    }
}
