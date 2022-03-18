using System;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MainForm : Form
    {
        private string[] PushToUndoOrRedo()
        {
            string[] Buff = {
                Meters.Text,
                Floor.Text,
                CountryT.Text,
                TownT.Text,
                DistrictT.Text,
                StreetT.Text,
                BuildingT.Text,
                FlatT.Text,
                Index.Text,
                MaterialType.Text,
                Kitchen.Checked.ToString(),
                Bath.Checked.ToString(),
                WC.Checked.ToString(),
                Basement.Checked.ToString(),
                Balcony.Checked.ToString()
        };
            return Buff;

        }


        private void PullFromUndoOrRedo(string[] Buff)
        {
            Meters.Text = Buff[0];
            Floor.Text = Buff[1];
            CountryT.Text = Buff[2];
            TownT.Text = Buff[3];
            DistrictT.Text = Buff[4];
            StreetT.Text = Buff[5];
            BuildingT.Text = Buff[6];
            FlatT.Text = Buff[7];
            Index.Text = Buff[8];
            MaterialType.Text = Buff[9];
            Kitchen.Checked = bool.Parse(Buff[10]);
            Bath.Checked = bool.Parse(Buff[11]);
            WC.Checked = bool.Parse(Buff[12]);
            Basement.Checked = bool.Parse(Buff[13]);
            Balcony.Checked = bool.Parse(Buff[14]);
        }
        private void Redo_Click(object sender, EventArgs e)
        {
            if (redoAction.Count < 1)
            {
                return;
            }

            if (undoAction.Count == 0)
            {
                undoAction.Push(PushToUndoOrRedo());
            }
            PullFromUndoOrRedo(redoAction.Pop());
            undoAction.Push(PushToUndoOrRedo());
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            if (undoAction.Count < 1)
            {
                return;
            }

            if (redoAction.Count == 0)
            {
                redoAction.Push(PushToUndoOrRedo());
            }
            PullFromUndoOrRedo(undoAction.Pop());
            redoAction.Push(PushToUndoOrRedo());
        }

        private void Meters_KeyDown(object sender, KeyEventArgs e)
        {
            undoAction.Push(PushToUndoOrRedo());
        }

        private void MaterialType_MouseClick(object sender, MouseEventArgs e)
        {
            undoAction.Push(PushToUndoOrRedo());
        }

        private void Floor_KeyDown(object sender, KeyEventArgs e)
        {
            undoAction.Push(PushToUndoOrRedo());
        }

        private void CountryT_KeyDown(object sender, KeyEventArgs e)
        {
            undoAction.Push(PushToUndoOrRedo());
        }

        private void TownT_KeyDown(object sender, KeyEventArgs e)
        {
            undoAction.Push(PushToUndoOrRedo());
        }

        private void DistrictT_KeyDown(object sender, KeyEventArgs e)
        {
            undoAction.Push(PushToUndoOrRedo());
        }

        private void StreetT_KeyDown(object sender, KeyEventArgs e)
        {
            undoAction.Push(PushToUndoOrRedo());
        }

        private void BuildingT_KeyDown(object sender, KeyEventArgs e)
        {
            undoAction.Push(PushToUndoOrRedo());
        }

        private void FlatT_KeyDown(object sender, KeyEventArgs e)
        {
            undoAction.Push(PushToUndoOrRedo());
        }

        private void Index_KeyDown(object sender, KeyEventArgs e)
        {
            undoAction.Push(PushToUndoOrRedo());
        }

        private void Kitchen_Click(object sender, EventArgs e)
        {
            undoAction.Push(PushToUndoOrRedo());
        }

        private void Bath_KeyDown(object sender, KeyEventArgs e)
        {
            undoAction.Push(PushToUndoOrRedo());
        }

        private void WC_KeyDown(object sender, KeyEventArgs e)
        {
            undoAction.Push(PushToUndoOrRedo());
        }

        private void Basement_KeyDown(object sender, KeyEventArgs e)
        {
            undoAction.Push(PushToUndoOrRedo());
        }

        private void Balcony_KeyDown(object sender, KeyEventArgs e)
        {
            undoAction.Push(PushToUndoOrRedo());
        }
    }
}
