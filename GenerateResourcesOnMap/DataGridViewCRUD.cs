using System;
using System.Collections.Generic;
using System.Drawing;
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
        public static void Create(int[,] matr, DataGridView dataGridView, ImageList imageList, Label label)
        {
            //указываем контроллу в который пишем количество строк и столбцов
            dataGridView.RowCount = matr.GetLength(0);
            
            dataGridView.ColumnCount = matr.GetLength(1);

            //отмечаем цвета зон
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    bool flag = ResourceGenerator.IsEmptyCell(rnd.Next(1, 101));
                    if (flag && matr[i, j] != 1)
                    {
                        dataGridView.Rows[i].Cells[j].Value = "null";
                    }

                    if (matr[i, j] == 1)
                    {
                        dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Green;
                    }
                    if (matr[i, j] <= 400 && matr[i, j] > 1)
                    {
                        dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Yellow;
                        if (!flag)
                        {
                            Image img = imageList.Images[23];
                            int localRand = rnd.Next(1, 101);
                            //create structure
                            if (localRand == 1)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateStructure(rnd.Next(1, 101))];
                            }
                            if (localRand > 1 && localRand <= 30)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateDecoration(rnd.Next(1, 101))];
                            }
                            if (localRand > 30 && localRand <= 46)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateResource(rnd.Next(1, 101))];
                            }


                            DataGridViewImageCell ImageCell = new DataGridViewImageCell();
                            dataGridView.Rows[i].Cells[j] = ImageCell;
                            dataGridView.Rows[i].Cells[j].Value = img;
                        }
                        
                    }
                    if (matr[i, j] <= 1600 && matr[i, j] > 400)
                    {
                        dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Blue;
                        if (!flag)
                        {
                            Image img = imageList.Images[23];
                            int localRand = rnd.Next(1, 101);
                            //create structure
                            if (localRand == 1)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateStructure(rnd.Next(1, 101))];
                            }
                            if (localRand > 1 && localRand <= 27)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateDecoration(rnd.Next(1, 101))];
                            }
                            if (localRand > 27 && localRand <= 46)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateResource(rnd.Next(1, 101))];
                            }
                            DataGridViewImageCell ImageCell = new DataGridViewImageCell();
                            dataGridView.Rows[i].Cells[j] = ImageCell;
                            dataGridView.Rows[i].Cells[j].Value = img;
                        }
                    }
                    if (matr[i, j] <= 3600 && matr[i, j] > 1600)
                    {
                        dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Brown;
                        if (!flag)
                        {
                            Image img = imageList.Images[23];
                            int localRand = rnd.Next(1, 101);
                            //create structure
                            if (localRand == 1)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateStructure(rnd.Next(1, 101))];
                            }
                            if (localRand > 1 && localRand <= 22)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateDecoration(rnd.Next(1, 101))];
                            }
                            if (localRand > 22 && localRand <= 44)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateResource(rnd.Next(1, 101))];
                            }
                            DataGridViewImageCell ImageCell = new DataGridViewImageCell();
                            dataGridView.Rows[i].Cells[j] = ImageCell;
                            dataGridView.Rows[i].Cells[j].Value = img;
                        }
                        
                    }
                    if (matr[i, j] <= 6400 && matr[i, j] > 3600)
                    {
                        dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Cyan;
                        if (!flag)
                        {
                            Image img = imageList.Images[23];
                            int localRand = rnd.Next(1, 101);
                            //create structure
                            if (localRand == 1)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateStructure(rnd.Next(1, 101))];
                            }
                            if (localRand > 1 && localRand <= 19)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateDecoration(rnd.Next(1, 101))];
                            }
                            if (localRand > 19 && localRand <= 44)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateResource(rnd.Next(1, 101))];
                            }
                            DataGridViewImageCell ImageCell = new DataGridViewImageCell();
                            dataGridView.Rows[i].Cells[j] = ImageCell;
                            dataGridView.Rows[i].Cells[j].Value = img;
                        }
                    }
                    if (matr[i, j] <= 14400 && matr[i, j] > 6400)
                    {
                        dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Fuchsia;
                        if (!flag)
                        {
                            Image img = imageList.Images[23];
                            int localRand = rnd.Next(1, 101);
                            //create structure
                            if (localRand == 1)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateStructure(rnd.Next(1, 101))];
                            }
                            if (localRand > 1 && localRand <= 14)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateDecoration(rnd.Next(1, 101))];
                            }
                            if (localRand > 14 && localRand <= 42)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateResource(rnd.Next(1, 101))];
                            }
                            DataGridViewImageCell ImageCell = new DataGridViewImageCell();
                            dataGridView.Rows[i].Cells[j] = ImageCell;
                            dataGridView.Rows[i].Cells[j].Value = img;
                        }
                       
                    }
                    if (matr[i, j] <= 25600 && matr[i, j] > 14400)
                    {
                        dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Orange;
                        if (!flag)
                        {
                            Image img = imageList.Images[23];
                            int localRand = rnd.Next(1, 101);
                            //create structure
                            if (localRand == 1)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateStructure(rnd.Next(1, 101))];
                            }
                            if (localRand > 1 && localRand <= 16)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateDecoration(rnd.Next(1, 101))];
                            }
                            if (localRand > 16 && localRand <= 46)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateResource(rnd.Next(1, 101))];
                            }
                            DataGridViewImageCell ImageCell = new DataGridViewImageCell();
                            dataGridView.Rows[i].Cells[j] = ImageCell;
                            dataGridView.Rows[i].Cells[j].Value = img;
                        }
                        
                    }
                    if (matr[i, j] <= 40000 && matr[i, j] > 25600)
                    {
                        dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Red;
                        if (!flag)
                        {
                            Image img = imageList.Images[23];
                            int localRand = rnd.Next(1, 101);
                            //create structure
                            if (localRand == 1)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateStructure(rnd.Next(1, 101))];
                            }
                            if (localRand > 1 && localRand <= 16)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateDecoration(rnd.Next(1, 101))];

                            }
                            if (localRand > 16 && localRand <= 46)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateResource(rnd.Next(1, 101))];
                            }
                            DataGridViewImageCell ImageCell = new DataGridViewImageCell();
                            dataGridView.Rows[i].Cells[j] = ImageCell;
                            dataGridView.Rows[i].Cells[j].Value = img;
                        }
                        
                    }
                        
                }
            }

            for (int i = 0; i <= dataGridView.Columns.Count - 1; i++)
            {
                dataGridView.Columns[i].Width = 25;
                dataGridView.Rows[i].Height = 25;

            }
            label.Text = "Загрузка завершена!";
        }
    }
}
