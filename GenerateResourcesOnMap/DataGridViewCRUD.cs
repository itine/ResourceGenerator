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
        public static void Create(int[,] matr, DataGridView dataGridView, ImageList imageList, Label label, List<Image> allMonsters, ProgressBar progressBar)
        {
            //указываем контроллу в который пишем количество строк и столбцов
            dataGridView.RowCount = matr.GetLength(0);
            dataGridView.ColumnCount = matr.GetLength(1);

            progressBar.Maximum = matr.GetLength(0) * 2;
            int progressBarValue = 0;

            //окраска фона
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                progressBar.Value = progressBarValue++;
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    
                    if (matr[i, j] == 1)
                    {
                        dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Green;
                    }
                    if (matr[i, j] <= 400 && matr[i, j] > 1)
                    {
                        dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.WhiteSmoke;
                    }
                    if (matr[i, j] <= 1600 && matr[i, j] > 400)
                    {
                        dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.DarkGreen;
                    }
                    if (matr[i, j] <= 3600 && matr[i, j] > 1600)
                    {
                        dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.DarkSlateBlue;
                    }
                    if (matr[i, j] <= 6400 && matr[i, j] > 3600)
                    {
                        dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.DimGray;
                    }
                    if (matr[i, j] <= 14400 && matr[i, j] > 6400)
                    {
                        dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.DarkGoldenrod;
                    }
                    if (matr[i, j] <= 25600 && matr[i, j] > 14400)
                    {
                        dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.DarkOliveGreen;
                    }
                    if (matr[i, j] <= 40000 && matr[i, j] > 25600)
                    {
                        dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.DarkRed;
                    }
                    if (matr[i, j] > 40000)
                    {
                        dataGridView.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.Black;
                    }
                }
            }
            for (int i = 0; i < matr.GetLength(0); i++)
            {
                progressBar.Value = progressBarValue++;
                for (int j = 0; j < matr.GetLength(1); j++)
                {
                    if (dataGridView.Rows[i].Cells[j].Value != null)
                        continue;

                    if (!ResourceGenerator.IsEmptyCell(rnd.Next(1, 101)))
                    {
                        //bool flag = false;
                        //if (i != 0)
                        //    foreach (var monster in allMonsters)
                        //    {
                        //        if (dataGridView.Rows[i - 1].Cells[j].Value != null)
                        //        {
                        //            Image monsterImg = imageList.Images[23];
                        //            DataGridViewImageCell MonsterImageCell = new DataGridViewImageCell();
                        //            dataGridView.Rows[i].Cells[j] = MonsterImageCell;
                        //            dataGridView.Rows[i].Cells[j].Value = monsterImg;
                        //            flag = true;
                        //        }
                        //    }
                        //if (flag)
                        //    break;

                        if (matr[i, j] <= 400 && matr[i, j] > 1)
                        {
                            Image img = imageList.Images[23];
                            int localRand = rnd.Next(1, 101);
                            //create structure
                            if (localRand == 1)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateStructure(rnd.Next(1, 101))];
                            }
                            if (localRand > 1 && localRand <= 35)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateDecoration(rnd.Next(1, 101))];
                            }
                            if (localRand > 35 && localRand <= 56)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateResource(rnd.Next(1, 101))];
                                if (rnd.Next(1, 101) <= 81)
                                {
                                    Image monsterImg = imageList.Images[ResourceGenerator.GenerateMonster(1, rnd.Next(1, 101))];
                                    DataGridViewImageCell MonsterImageCell = new DataGridViewImageCell();
                                    if (dataGridView.Rows[i].Cells[j + 1].Style.BackColor == Color.WhiteSmoke)
                                    {
                                        dataGridView.Rows[i].Cells[j + 1] = MonsterImageCell;
                                        dataGridView.Rows[i].Cells[j + 1].Value = monsterImg;
                                    }
                                    else
                                    {
                                        dataGridView.Rows[i].Cells[j - 1] = MonsterImageCell;
                                        dataGridView.Rows[i].Cells[j - 1].Value = monsterImg;
                                    }
                                }
                            }
                            if (localRand > 56 && localRand <= 58)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateArtifact(rnd.Next(1, 101))];
                                Image monsterImg = imageList.Images[ResourceGenerator.GenerateMonster(1, rnd.Next(1, 101))];
                                DataGridViewImageCell MonsterImageCell = new DataGridViewImageCell();
                                if (dataGridView.Rows[i].Cells[j + 1].Style.BackColor == Color.WhiteSmoke)
                                {
                                    dataGridView.Rows[i].Cells[j + 1] = MonsterImageCell;
                                    dataGridView.Rows[i].Cells[j + 1].Value = monsterImg;
                                }
                                else
                                {
                                    dataGridView.Rows[i].Cells[j - 1] = MonsterImageCell;
                                    dataGridView.Rows[i].Cells[j - 1].Value = monsterImg;
                                }
                            }
                            if (localRand > 58 && localRand <= 59)
                            {
                                img = imageList.Images[71];
                            }
                            if (localRand > 59 && localRand <= 100)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateMonster(1, rnd.Next(1, 101))];
                            }
                            DataGridViewImageCell ImageCell = new DataGridViewImageCell();
                            dataGridView.Rows[i].Cells[j] = ImageCell;
                            dataGridView.Rows[i].Cells[j].Value = img;

                        }
                        if (matr[i, j] <= 1600 && matr[i, j] > 400)
                        {
                            Image img = imageList.Images[23];
                            int localRand = rnd.Next(1, 101);
                            //create structure
                            if (localRand == 1)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateStructure(rnd.Next(1, 101))];
                            }
                            if (localRand > 1 && localRand <= 32)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateDecoration(rnd.Next(1, 101))];
                            }
                            if (localRand > 32 && localRand <= 56)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateResource(rnd.Next(1, 101))];
                                if (rnd.Next(1, 101) <= 81)
                                {
                                    Image monsterImg = imageList.Images[ResourceGenerator.GenerateMonster(2, rnd.Next(1, 101))];
                                    DataGridViewImageCell MonsterImageCell = new DataGridViewImageCell();
                                    if (dataGridView.Rows[i].Cells[j + 1].Style.BackColor == Color.DarkGreen)
                                    {
                                        dataGridView.Rows[i].Cells[j + 1] = MonsterImageCell;
                                        dataGridView.Rows[i].Cells[j + 1].Value = monsterImg;
                                    }
                                    else
                                    {
                                        dataGridView.Rows[i].Cells[j - 1] = MonsterImageCell;
                                        dataGridView.Rows[i].Cells[j - 1].Value = monsterImg;
                                    }
                                }
                            }
                            if (localRand > 56 && localRand <= 58)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateArtifact(rnd.Next(1, 101))];
                                Image monsterImg = imageList.Images[ResourceGenerator.GenerateMonster(2, rnd.Next(1, 101))];
                                DataGridViewImageCell MonsterImageCell = new DataGridViewImageCell();
                                if (dataGridView.Rows[i].Cells[j + 1].Style.BackColor == Color.DarkGreen)
                                {
                                    dataGridView.Rows[i].Cells[j + 1] = MonsterImageCell;
                                    dataGridView.Rows[i].Cells[j + 1].Value = monsterImg;
                                }
                                else
                                {
                                    dataGridView.Rows[i].Cells[j - 1] = MonsterImageCell;
                                    dataGridView.Rows[i].Cells[j - 1].Value = monsterImg;
                                }
                            }
                            if (localRand > 58 && localRand <= 59)
                            {
                                img = imageList.Images[71];
                            }
                            if (localRand > 59 && localRand <= 100)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateMonster(2, rnd.Next(1, 101))];
                            }
                            DataGridViewImageCell ImageCell = new DataGridViewImageCell();
                            dataGridView.Rows[i].Cells[j] = ImageCell;
                            dataGridView.Rows[i].Cells[j].Value = img;
                        }
                        if (matr[i, j] <= 3600 && matr[i, j] > 1600)
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
                            if (localRand > 27 && localRand <= 54)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateResource(rnd.Next(1, 101))];
                                if (rnd.Next(1, 101) <= 81)
                                {
                                    Image monsterImg = imageList.Images[ResourceGenerator.GenerateMonster(3, rnd.Next(1, 101))];
                                    DataGridViewImageCell MonsterImageCell = new DataGridViewImageCell();
                                    if (dataGridView.Rows[i].Cells[j + 1].Style.BackColor == Color.DarkSlateBlue)
                                    {
                                        dataGridView.Rows[i].Cells[j + 1] = MonsterImageCell;
                                        dataGridView.Rows[i].Cells[j + 1].Value = monsterImg;
                                    }
                                    else
                                    {
                                        dataGridView.Rows[i].Cells[j - 1] = MonsterImageCell;
                                        dataGridView.Rows[i].Cells[j - 1].Value = monsterImg;
                                    }
                                }
                            }
                            if (localRand > 54 && localRand <= 57)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateArtifact(rnd.Next(1, 101))];
                                Image monsterImg = imageList.Images[ResourceGenerator.GenerateMonster(3, rnd.Next(1, 101))];
                                DataGridViewImageCell MonsterImageCell = new DataGridViewImageCell();
                                if (dataGridView.Rows[i].Cells[j + 1].Style.BackColor == Color.DarkSlateBlue)
                                {
                                    dataGridView.Rows[i].Cells[j + 1] = MonsterImageCell;
                                    dataGridView.Rows[i].Cells[j + 1].Value = monsterImg;
                                }
                                else
                                {
                                    dataGridView.Rows[i].Cells[j - 1] = MonsterImageCell;
                                    dataGridView.Rows[i].Cells[j - 1].Value = monsterImg;
                                }
                            }
                            if (localRand > 57 && localRand <= 59)
                            {
                                img = imageList.Images[71];
                            }
                            if (localRand > 59 && localRand <= 100)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateMonster(3, rnd.Next(1, 101))];
                            }
                            DataGridViewImageCell ImageCell = new DataGridViewImageCell();
                            dataGridView.Rows[i].Cells[j] = ImageCell;
                            dataGridView.Rows[i].Cells[j].Value = img;
                        }
                        if (matr[i, j] <= 6400 && matr[i, j] > 3600)
                        {
                            Image img = imageList.Images[23];
                            int localRand = rnd.Next(1, 101);
                            //create structure
                            if (localRand == 1)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateStructure(rnd.Next(1, 101))];
                            }
                            if (localRand > 1 && localRand <= 24)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateDecoration(rnd.Next(1, 101))];
                            }
                            if (localRand > 24 && localRand <= 54)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateResource(rnd.Next(1, 101))];
                                if (rnd.Next(1, 101) <= 81)
                                {
                                    Image monsterImg = imageList.Images[ResourceGenerator.GenerateMonster(4, rnd.Next(1, 101))];
                                    DataGridViewImageCell MonsterImageCell = new DataGridViewImageCell();
                                    if (dataGridView.Rows[i].Cells[j + 1].Style.BackColor == Color.DimGray)
                                    {
                                        dataGridView.Rows[i].Cells[j + 1] = MonsterImageCell;
                                        dataGridView.Rows[i].Cells[j + 1].Value = monsterImg;
                                    }
                                    else
                                    {
                                        dataGridView.Rows[i].Cells[j - 1] = MonsterImageCell;
                                        dataGridView.Rows[i].Cells[j - 1].Value = monsterImg;
                                    }
                                }
                            }
                            if (localRand > 54 && localRand <= 57)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateArtifact(rnd.Next(1, 101))];
                                Image monsterImg = imageList.Images[ResourceGenerator.GenerateMonster(4, rnd.Next(1, 101))];
                                DataGridViewImageCell MonsterImageCell = new DataGridViewImageCell();
                                if (dataGridView.Rows[i].Cells[j + 1].Style.BackColor == Color.DimGray)
                                {
                                    dataGridView.Rows[i].Cells[j + 1] = MonsterImageCell;
                                    dataGridView.Rows[i].Cells[j + 1].Value = monsterImg;
                                }
                                else
                                {
                                    dataGridView.Rows[i].Cells[j - 1] = MonsterImageCell;
                                    dataGridView.Rows[i].Cells[j - 1].Value = monsterImg;
                                }
                            }
                            if (localRand > 57 && localRand <= 59)
                            {
                                img = imageList.Images[71];
                            }
                            if (localRand > 59 && localRand <= 100)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateMonster(4, rnd.Next(1, 101))];
                            }
                            DataGridViewImageCell ImageCell = new DataGridViewImageCell();
                            dataGridView.Rows[i].Cells[j] = ImageCell;
                            dataGridView.Rows[i].Cells[j].Value = img;
                        }
                        if (matr[i, j] <= 14400 && matr[i, j] > 6400)
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
                            if (localRand > 19 && localRand <= 52)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateResource(rnd.Next(1, 101))];
                                if (rnd.Next(1, 101) <= 81)
                                {
                                    Image monsterImg = imageList.Images[ResourceGenerator.GenerateMonster(5, rnd.Next(1, 101))];
                                    DataGridViewImageCell MonsterImageCell = new DataGridViewImageCell();
                                    if (dataGridView.Rows[i].Cells[j + 1].Style.BackColor == Color.DarkGoldenrod)
                                    {
                                        dataGridView.Rows[i].Cells[j + 1] = MonsterImageCell;
                                        dataGridView.Rows[i].Cells[j + 1].Value = monsterImg;
                                    }
                                    else
                                    {
                                        dataGridView.Rows[i].Cells[j - 1] = MonsterImageCell;
                                        dataGridView.Rows[i].Cells[j - 1].Value = monsterImg;
                                    }
                                }
                            }
                            if (localRand > 52 && localRand <= 56)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateArtifact(rnd.Next(1, 101))];
                                Image monsterImg = imageList.Images[ResourceGenerator.GenerateMonster(5, rnd.Next(1, 101))];
                                DataGridViewImageCell MonsterImageCell = new DataGridViewImageCell();
                                if (dataGridView.Rows[i].Cells[j + 1].Style.BackColor == Color.DarkGoldenrod)
                                {
                                    dataGridView.Rows[i].Cells[j + 1] = MonsterImageCell;
                                    dataGridView.Rows[i].Cells[j + 1].Value = monsterImg;
                                }
                                else
                                {
                                    dataGridView.Rows[i].Cells[j - 1] = MonsterImageCell;
                                    dataGridView.Rows[i].Cells[j - 1].Value = monsterImg;
                                }
                            }
                            if (localRand > 56 && localRand <= 59)
                            {
                                img = imageList.Images[71];
                            }
                            if (localRand > 59 && localRand <= 100)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateMonster(5, rnd.Next(1, 101))];
                            }
                            DataGridViewImageCell ImageCell = new DataGridViewImageCell();
                            dataGridView.Rows[i].Cells[j] = ImageCell;
                            dataGridView.Rows[i].Cells[j].Value = img;
                        }
                        if (matr[i, j] <= 25600 && matr[i, j] > 14400)
                        {
                            Image img = imageList.Images[23];
                            int localRand = rnd.Next(1, 101);
                            //create structure
                            if (localRand == 1)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateStructure(rnd.Next(1, 101))];
                            }
                            if (localRand > 1 && localRand <= 21)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateDecoration(rnd.Next(1, 101))];
                            }
                            if (localRand > 21 && localRand <= 56)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateResource(rnd.Next(1, 101))];
                                if (rnd.Next(1, 101) <= 81)
                                {
                                    Image monsterImg = imageList.Images[ResourceGenerator.GenerateMonster(6, rnd.Next(1, 101))];
                                    DataGridViewImageCell MonsterImageCell = new DataGridViewImageCell();
                                    if (dataGridView.Rows[i].Cells[j + 1].Style.BackColor == Color.DarkOliveGreen)
                                    {
                                        dataGridView.Rows[i].Cells[j + 1] = MonsterImageCell;
                                        dataGridView.Rows[i].Cells[j + 1].Value = monsterImg;
                                    }
                                    else
                                    {
                                        dataGridView.Rows[i].Cells[j - 1] = MonsterImageCell;
                                        dataGridView.Rows[i].Cells[j - 1].Value = monsterImg;
                                    }
                                }
                            }
                            if (localRand > 56 && localRand <= 61)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateArtifact(rnd.Next(1, 101))];
                                Image monsterImg = imageList.Images[ResourceGenerator.GenerateMonster(6, rnd.Next(1, 101))];
                                DataGridViewImageCell MonsterImageCell = new DataGridViewImageCell();
                                if (dataGridView.Rows[i].Cells[j + 1].Style.BackColor == Color.DarkOliveGreen)
                                {
                                    dataGridView.Rows[i].Cells[j + 1] = MonsterImageCell;
                                    dataGridView.Rows[i].Cells[j + 1].Value = monsterImg;
                                }
                                else
                                {

                                    dataGridView.Rows[i].Cells[j - 1] = MonsterImageCell;
                                    dataGridView.Rows[i].Cells[j - 1].Value = monsterImg;
                                }
                            }
                            if (localRand > 61 && localRand <= 64)
                            {
                                img = imageList.Images[71];
                            }
                            if (localRand > 64 && localRand <= 100)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateMonster(6, rnd.Next(1, 101))];
                            }
                            DataGridViewImageCell ImageCell = new DataGridViewImageCell();
                            dataGridView.Rows[i].Cells[j] = ImageCell;
                            dataGridView.Rows[i].Cells[j].Value = img;

                        }
                        if (matr[i, j] <= 40000 && matr[i, j] > 25600)
                        {
                            Image img = imageList.Images[23];
                            int localRand = rnd.Next(1, 101);
                            //create structure
                            if (localRand == 1)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateStructure(rnd.Next(1, 101))];
                            }
                            if (localRand > 1 && localRand <= 21)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateDecoration(rnd.Next(1, 101))];
                            }
                            if (localRand > 21 && localRand <= 56)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateResource(rnd.Next(1, 101))];
                                if (rnd.Next(1, 101) <= 81)
                                {
                                    Image monsterImg = imageList.Images[ResourceGenerator.GenerateMonster(7, rnd.Next(1, 101))];
                                    DataGridViewImageCell MonsterImageCell = new DataGridViewImageCell();
                                    if (dataGridView.Rows[i].Cells[j + 1].Style.BackColor == Color.DarkRed)
                                    {
                                        dataGridView.Rows[i].Cells[j + 1] = MonsterImageCell;
                                        dataGridView.Rows[i].Cells[j + 1].Value = monsterImg;
                                    }
                                    else
                                    {
                                        dataGridView.Rows[i].Cells[j - 1] = MonsterImageCell;
                                        dataGridView.Rows[i].Cells[j - 1].Value = monsterImg;
                                    }
                                }
                            }
                            if (localRand > 56 && localRand <= 62)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateArtifact(rnd.Next(1, 101))];
                                Image monsterImg = imageList.Images[ResourceGenerator.GenerateMonster(7, rnd.Next(1, 101))];
                                DataGridViewImageCell MonsterImageCell = new DataGridViewImageCell();
                                if (dataGridView.Rows[i].Cells[j + 1].Style.BackColor == Color.DarkRed)
                                {
                                    dataGridView.Rows[i].Cells[j + 1] = MonsterImageCell;
                                    dataGridView.Rows[i].Cells[j + 1].Value = monsterImg;
                                }
                                else
                                {
                                    dataGridView.Rows[i].Cells[j - 1] = MonsterImageCell;
                                    dataGridView.Rows[i].Cells[j - 1].Value = monsterImg;
                                }
                            }
                            if (localRand > 62 && localRand <= 66)
                            {
                                img = imageList.Images[71];
                            }
                            if (localRand > 66 && localRand <= 100)
                            {
                                img = imageList.Images[ResourceGenerator.GenerateMonster(7, rnd.Next(1, 101))];
                            }
                            DataGridViewImageCell ImageCell = new DataGridViewImageCell();
                            dataGridView.Rows[i].Cells[j] = ImageCell;
                            dataGridView.Rows[i].Cells[j].Value = img;
                        }
                    }
                }
            }
            for (int k = 0; k <= dataGridView.Columns.Count - 1; k++)
            {
                dataGridView.Columns[k].Width = 25;
                dataGridView.Rows[k].Height = 25;
            }
            progressBar.Value = 0;
        }
    }
}
