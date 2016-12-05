using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateResourcesOnMap
{
    public class DataGridViewCRUD
    {

        private static readonly Random rnd = new Random();
        //------------Метод-считывающий-матрицу-из-DataGridView-в-массив-----------------------------
        /// <summary>
        /// Метод считывающий матрицу из указанного DataGridView в массив.
        /// </summary>
        /// <param name="dataGridView">DataGridView Из которого считываем матрицу.</param>
        /// <returns></returns>
        public static int[,] Read(DataGridView dataGridView)
        {
            int[,] matrs;
            //создаём новый массив размера dataGridView.RowCount на dataGridView.ColumnCount
            //где RowCount количество строк у элемента, а ColumnCount количество столбцов
            matrs = new int[dataGridView.RowCount, dataGridView.ColumnCount];
            try//отлов исключений
            {
                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView.ColumnCount; j++)
                    {
                        //Преобразуем значения из ячеек в числа, и пишем в массив
                        //Если не число то происходит вызов исключения и его обработка
                        matrs[i, j] = Convert.ToInt32(dataGridView.Rows[i].Cells[j].Value);
                    }
                }
            }
            catch (System.Exception e)//обработка пойманного исключения
            {
                throw new Exception(e.Message + "\n(Использование букв и символов недопустимо!)");
            }
            return matrs;
        }
        //------------Метод-записывающий-матрицу-из-массива-в-DataGridView---------------------------
        /// <summary>
        /// Метод записывающий матрицу из массива в указанный DataGridView
        /// </summary>
        /// <param name="matr">Матрица которую выводим в DataGridView</param>
        /// <param name="dataGridView">DataGridView в который выводим</param>
        public static void Create(int[,] matr, DataGridView dataGridView, ImageList imageList)
        {
            DataGridViewImageCell DGic = new DataGridViewImageCell();
            //указываем контроллу в который пишем количество строк и столбцов
            dataGridView.RowCount = matr.GetLength(0);
            dataGridView.ColumnCount = matr.GetLength(1);
            //отмечаем цвета зон
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    int local = rnd.Next(1, 101);
                    if (ResourceGenerator.IsEmptyCell(local))
                        dataGridView.Rows[i].Cells[j].Value = imageList.Images[23];
                    if (matr[i, j] == 1)
                    {
                        dataGridView.Rows[i].Cells[j].Value = imageList.Images[0];
                        dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Green;
                    }
                    if (matr[i, j] <= 400 && matr[i, j] > 1)
                    {
                        dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Yellow;
                        //create structure
                        //if (rnd.Next(1, 101) == 1)
                        //{
                            var img = imageList.Images[ResourceGenerator.GenerateStructure(rnd.Next(1,101))];
                        
                        //((DataGridViewImageCell)dataGridView.Rows[i].Cells[j]).Value = img;
                        //}
                    }
                    if (matr[i, j] <= 1600 && matr[i, j] > 400)
                        dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Blue;
                    if (matr[i, j] <= 3600 && matr[i, j] > 1600)
                       dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Brown;
                    if (matr[i, j] <= 6400 && matr[i, j] > 3600)
                        dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Cyan;
                    if (matr[i, j] <= 14400 && matr[i, j] > 6400)
                        dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Fuchsia;
                    if (matr[i, j] <= 25600 && matr[i, j] > 14400)
                        dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Orange;
                    if (matr[i, j] <= 40000 && matr[i, j] > 25600)
                        dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Red;
                    
                    //int local = rand.Next(1, 101);
                    //if (ResourceGenerator.IsEmptyCell(local))
                    //    dataGridView.Rows[i].Cells[j].Value = 0;
                    //else
                    //{
                    //    dataGridView.Rows[i].Cells[j].Value = matr[i, j];
                    //    //if (matr[i, j] <= 400 && matr[i, j] > 1)
                    //    //{
                    //    //    var img = imageList.Images[ResourceGenerator.GenerateStructure(randForStructure.Next(1,101))];
                    //    //    DGic.Value = img;
                    //    //    dataGridView[i, j] = DGic;
                    //    //}
                    //}
                        
                }
            }
            for (int i = 0; i <= dataGridView.Columns.Count - 1; i++)
            {
                dataGridView.Columns[i].Width = 25;
            }
            //for (int j = 0; j <= dataGridView.Columns.Count - 1; j++)
            //{
            //    for (int k = 0; k <= dataGridView.Rows.Count -1; k++)
            //    {
                    
            //    }
            //}
        }
    }
}
