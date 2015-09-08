using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Matematico.Components
{
    public partial class UserList : DataGridView
    {
        private Dictionary<String, String> Names;
        
        public int ConnectedUsers
        {
            get { return Names.Count; }
        }



        public UserList()
        {
            Names = new Dictionary<string, string>();

            InitializeComponent();
        }

        public void AddScore(string username, int points, int missing)
        {
            foreach (DataGridViewRow row in Rows)
            {
                object val = row.Cells[0].Value;
                if (val != null && val.ToString() == username)
                {
                    Rows[row.Index].Cells[1].Value = points;
                    Rows[row.Index].Cells[2].Value = missing;
                }
            }
        }

        public void RemoveScore(string uid)
        {
            if(Names.ContainsKey(uid))
            {
                foreach (DataGridViewRow row in Rows)
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == Names[uid])
                    {
                        row.Cells[1].Value = "0";
                        row.Cells[2].Value = "0";
                    }
            }
        }

        public void AddUser(string uid, string username)
        {
            if (Names.ContainsKey(uid)) 
                Names.Remove(uid);
            
            Names.Add(uid, username);

            Rows.Add(new object[] {username, 0, 0});
        }

        public void RemoveUser(string uid)
        {
            if (Names.ContainsKey(uid))
            {
                foreach (DataGridViewRow row in Rows)
                    if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == Names[uid])
                        Rows.RemoveAt(row.Index);

                Names.Remove(uid);
            } 
        }

        public void ClearUsers()
        {
            Rows.Clear();
            Names.Clear();
        }

        public bool IsUser(string uid)
        {
            return Names.ContainsKey(uid);
        }

        public void RenameUser(string uid, string newname)
        {
            if (Names.ContainsKey(uid))
            {
                foreach (DataGridViewRow row in Rows)
                    if (row.Cells[0].Value.ToString() == Names[uid])
                        Rows.RemoveAt(row.Index);

                Names[uid] = newname;

                Rows.Add(new object[] { newname, 0, 0 });
            }
        }

        private void UserList_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.Value != null && Names.ContainsKey(e.Value.ToString())) 
                Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Names[e.Value.ToString()];
        }
    }
}
