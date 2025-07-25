using System.Data.SQLite;
using Org.BouncyCastle.Tls;
using System.Diagnostics.Eventing.Reader;
using static System.ComponentModel.Design.ObjectSelectorEditor;
namespace practiceapp
{
  
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += taskload;
        }
        string nulltask;
        DateTime nulldate;
        int x = 1;

        private void Connectdatabase()
        {
            tasks.Items.Clear();
            string connection = "Data Source=tasklist.db;Version=3;";
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connection))
                {
                    conn.Open();
                    MessageBox.Show("Connected to MySQL successfully");
                    string query = "SELECT * FROM tasked";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string name = reader["tasks"].ToString();
                            string date = reader["date"].ToString();

                            string displayText = $"{name} - {date}";
                            tasks.Items.Add(displayText, false); // false = not checked
                        }
                    }
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("MySQL connection failed" + ex.Message);
            }
        }

        private void taskload(object sender, EventArgs e)
        {
            Connectdatabase();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(taskbox.Text)) {
             
                 nulltask = "task"+x;
                nulldate = DateTime.Now;
                task_obj t1 = new task_obj(nulltask, nulldate);
                tasks.Items.Add(t1);
                
                x++;
                
            }
            else
            {
                task_obj t1 = new task_obj(taskbox.Text, date.Value);
     
                tasks.Items.Add(t1);

                string connection = "Data Source=tasklist.db;Version=3;";
                using (SQLiteConnection conn = new SQLiteConnection(connection))
                {
                    conn.Open();

                    string query = "INSERT INTO tasked (tasks, date) VALUES (@name, @date)";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", taskbox.Text);
                        cmd.Parameters.AddWithValue("@date", date.Value);
                        cmd.ExecuteNonQuery();
                    }
                }

           
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (tasks.SelectedItem != null)
            {
                String selected = tasks.SelectedItem.ToString();

                tasks.Items.Remove(tasks.SelectedItem);
                string connection = "Data Source=tasklist.db;Version=3;";
                using (SQLiteConnection conn = new SQLiteConnection(connection))
                {
                    conn.Open();

                    string query = "DELETE FROM tasks WHERE tasked = @name";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", selected);
                        cmd.ExecuteNonQuery();
                    }
                }

            } else
            {
                MessageBox.Show("please select a task to delete");
            }
        }

        private void tasks_SelectedIndexChanged(object sender, EventArgs e)
        { }

            

        private void clearall_Click(object sender, EventArgs e)
        {
            tasks.Items.Clear();

            string connection = "Data Source=tasklist.db;Version=3;";
            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                conn.Open();

                string query = "DELETE FROM tasked;";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

public class task_obj
{
    String new_task; //new task variable
    DateTime task_date; //date variable

    public task_obj(String task, DateTime dateval)
    {
        new_task = task;
        task_date = dateval;
    }

    public override string ToString()
    {
        return $"{new_task} ({task_date.ToShortDateString()})";
    }

}
