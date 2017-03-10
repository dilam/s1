using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO
{
    class Splitter
    {
        public static void split(string input_path, string dir_path, int nb)
        {
            System.IO.FileStream inf
                = new System.IO.FileStream(input_path,
                System.IO.FileMode.OpenOrCreate,
                System.IO.FileAccess.ReadWrite);
            System.IO.BinaryReader reader = new System.IO.BinaryReader(inf);
            System.IO.BinaryWriter[] writers = new System.IO.BinaryWriter[nb];
            for (int x = 0; x < nb; x++)
            {
                writers[x] = new System.IO.BinaryWriter(new System.IO.FileStream(dir_path + "/part_" + (x + 1) + ".ACDC",
                                                        System.IO.FileMode.Create,
                                                        System.IO.FileAccess.Write));
            }
            int j = 0;
            while (reader.PeekChar() != -1)
            {
                char c = reader.ReadChar();
                writers[j % nb].Write(c);
                j = j + 1;
            }
            inf.Close();
            reader.Close();
            for (int i = 0; i < nb; i++)
            {
                writers[i].Close();
            }
        }

        public static void merge(string output_path, string dir_path, int nb)
        {
            System.IO.FileStream fs
                    = new System.IO.FileStream(output_path,
                    System.IO.FileMode.OpenOrCreate,
                    System.IO.FileAccess.ReadWrite);
            System.IO.BinaryWriter writer = new System.IO.BinaryWriter(fs);
            System.IO.BinaryReader[] readers = new System.IO.BinaryReader[nb];
            for(int x = 0; x < nb; x++)
            {
                readers[x] = new System.IO.BinaryReader(new System.IO.FileStream(dir_path + "/part_" + (x + 1) + ".ACDC",
                                                            System.IO.FileMode.Open,
                                                            System.IO.FileAccess.Read));
            }
            int j = 0;
            while (readers[j % nb].PeekChar() != -1)
            {
                char c = readers[j].ReadChar();
                writer.Write(c);
                j = (j + 1) % nb;
            }

            fs.Close();
            writer.Close();
            for (int i = 0; i < nb; i++)
            {
                readers[i].Close();
            }
        }
    }
}
