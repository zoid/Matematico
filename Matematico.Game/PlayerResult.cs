using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Matematico.Game
{
    public class PlayerResult
    {
        public int Total;
        public int Missing;
        public string Name;

        public int[] Line;
        public int[] Column;
        public int[] Diagonal;

        public PlayerResult(string username, int[,] board)
        {
            Missing = Points.Missing(board);
            
            Line = Points.Lines(board);
            Column = Points.Columns(board);
            Diagonal = Points.Diagonals(board);

            Total = Line.Sum() + Column.Sum() + Diagonal.Sum();

            Name = username;
        }

        // Deserialization constructor.
        public PlayerResult(SerializationInfo info, StreamingContext ctxt)
        {
            Total = (int)info.GetValue("Total", typeof(int));
            Missing = (int)info.GetValue("Missing", typeof(int));
            Name = (string)info.GetValue("Name", typeof(string));

            Line = (int[])info.GetValue("Line", typeof(int[]));
            Column = (int[])info.GetValue("Column", typeof(int[]));
            Diagonal = (int[])info.GetValue("Diagonal", typeof(int[]));
        }

        // Serialization
        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Total", Total);
            info.AddValue("Missing", Missing);
            info.AddValue("Name", Name);

            info.AddValue("Line", Line);
            info.AddValue("Column", Column);
            info.AddValue("Diagonal", Diagonal);
        }

        public string Pack()
        {
            using (MemoryStream stream = new MemoryStream())
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(stream, this);

                return Convert.ToBase64String(stream.ToArray());
            }
        }


        public static PlayerResult Unpack(string obj)
        {
            PlayerResult instance = null;
            byte[] arr = Convert.FromBase64String(obj);

            try
            {
                using (MemoryStream stream = new MemoryStream(arr))
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    instance = (PlayerResult)formatter.Deserialize(stream);
                }
            }
            catch (Exception e)
            {
            }

            return instance;
        }

    }
}
