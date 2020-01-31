using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Main_Module
{
    public static class StudentRoutine
    {
        private static List<User> users = new List<User>();
        private static string directoryPath = @"C:\Student Routine Data";
        private static string filePath = @"C:\Student Routine Data\Data.txt";

        #region Methods
        //IsMember method
        public static int IsMember(string email)
        {
            int index = -1;

            foreach (User user in users)
            {
                if (user.Email == email)
                {
                    index = users.IndexOf(user);
                }
            }
            return index;
        }//end method

        //AddUser method
        private static void AddUser(User user)
        {
            users.Add(user);
        }//end method

        //Save method
        public static void SaveAll()
        {
            try
            {
                if (!Directory.Exists(directoryPath))
                    Directory.CreateDirectory(directoryPath);

                FileStream fs = new FileStream(filePath, FileMode.Create,
                  FileAccess.ReadWrite, FileShare.None);

                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(fs, users);
                fs.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Saving Error", "Error");

            }
        }//end method

        //Restore method
        public static void RestoreAll()
        {
            try
            {
                if (!Directory.Exists(directoryPath))
                    return;

                FileStream fs = new FileStream(filePath, FileMode.Open,
                     FileAccess.ReadWrite, FileShare.None);
                BinaryFormatter serializer = new BinaryFormatter();

                users = (List<User>)serializer.Deserialize(fs);
                fs.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Restore Error", "Error");
            }
        }//end method
        #endregion Methods

        #region Property

        public static int HasUser
        {
            get
            {
                return users.Count;
            }
        }
        public static List<User> Users
        {
            get
            {
                return users;
            }
            set
            {
                users = value;
            }
        }
        #endregion Property
    }//end class
}//and namespace
