namespace shootingBaskets
{
    partial class shootingBaskets
    {
        static void Main(string[] args)
        {
            int[] ShotsMade;
            int totalShots = 0;
            int countOfShots = 0;
            string inValue;
            double averageShotsMade;

            try
            {
                Console.Write("How many shots will you make? ");
                inValue = Console.ReadLine();
                countOfShots = int.Parse(inValue);
                ShotsMade = new int[countOfShots];

                for (int i = 0; i < countOfShots; i++)
                {
                    Console.Write("Enter shots {0}: ", i + 1);
                    inValue = Console.ReadLine();
                    ShotsMade[i] = int.Parse(inValue);
                    totalShots += ShotsMade[i];
                }

                averageShotsMade = totalShots / countOfShots;
                Console.WriteLine("Average is (0)", averageShotsMade);

            }

            catch (System.FormatException e)
            {
                Console.Error.WriteLine("Problem with one of " + "the operands = Cannot compute average!");
                Console..Error.WriteLine("Exception type: (0)", e.Message);
            }

            catch (System.DivideByZeroException e)
            {
                Console.Error.WriteLine("No shots were " + "entered = Cannot compute average!");
                Console..Error.WriteLine("Exception type: (0)", e.Message);

            }

            catch (System.ArithmeticException e);
            {
                Console.Error.WriteLine("Error in your " + "arithmetic or casting.");
                Console..Error.WriteLine("Exception type: (0)", e.Message);
            }

            catch (System.Exception e)
            {
                Console.Error.WriteLine("Any other problem " + "Cannot compute average!");
                Console..Error.WriteLine("Exception type: (0)", e.Message);
            }

            finally
            {
                Console.WriteLine("...\n...\n...\n" + "Terminated Normally!!!");
            }

            }

        }

            }

       } #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "shootingBaskets";
        }

        #endregion
    }
}

