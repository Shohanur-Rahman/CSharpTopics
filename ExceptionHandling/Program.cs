using System;
using System.IO;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                streamReader = new StreamReader(@"F:\dot net\CSharpTopicsCover\topics1.txt");

                Console.WriteLine(streamReader.ReadToEnd());


            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (streamReader != null)
                    streamReader.Close();
            }

        }
    }
}
