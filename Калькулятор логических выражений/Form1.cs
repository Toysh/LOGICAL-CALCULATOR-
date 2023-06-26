using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Калькулятор_логических_выражений
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Получаем логическое выражение из текстового поля
            string expression = textBox1.Text;

            // Заменяем операторы на символы
            expression = expression.Replace("&&", "∧").Replace("||", "∨").Replace("!", "¬").Replace("^", "⊕").Replace("=>", "→").Replace("==", "≡").Replace("<=", "←");

            // Вычисляем значение выражения
            bool result = LogicalExpressionEvaluator.EvaluateLogicalExpression(expression);


            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            //string expression = "A && B || C <= D && E => F == G"; // ваше логическое выражение

            // Определение списка переменных
            List<char> variables = new List<char>();

            // Подсчет количества переменных и операторов
            int variableCount = 0;
            int operatorCount = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                char symbol = expression[i];

                if (Char.IsLetter(symbol))
                {
                    if (!variables.Contains(symbol))
                    {
                        variables.Add(symbol); // если символ - буква, заносим ее в список переменных (если ее там еще нет)
                        variableCount++; // увеличиваем счетчик переменных
                    }



                    // Если следующий символ - буква
                    while (i + 1 < expression.Length && Char.IsLetter(expression[i + 1]))
                    {
                        i++; // пропускаем оставшиеся символы
                    }
                }
                else if (symbol == '!' ||
                         (symbol == '|' && i + 1 < expression.Length && expression[i + 1] == '|') ||
                         (symbol == '&' && i + 1 < expression.Length && expression[i + 1] == '&') ||
                         (symbol == '=' && i + 1 < expression.Length && expression[i + 1] == '=') || // обработка операторов "==", "<=" и "=>"
                         (symbol == '<' && i + 1 < expression.Length && expression[i + 1] == '=') ||
                         (symbol == '>' && i + 1 < expression.Length && expression[i + 1] == '=') ||
                         (symbol == '-' && i + 1 < expression.Length && expression[i + 1] == '>'))
                {
                    operatorCount++; // если символ - оператор, увеличиваем счетчик операторов

                    // Если следующий символ - часть оператора
                    if (i + 2 < expression.Length && ((symbol == '&' && expression[i + 1] == '&') || // обработка операторов "&&" и "||"
                                                       (symbol == '|' && expression[i + 1] == '|')))
                    {
                        i++; // пропускаем вторую часть оператора
                    }
                    else if (i + 3 < expression.Length && symbol == '=' && expression[i + 1] == '=' && expression[i + 2] == '>') // обработка оператора "=>"
                    {
                        i += 2; // пропускаем оставшиеся символы
                    }
                    else if (i + 2 < expression.Length && symbol == '-' && expression[i + 1] == '>') // обработка оператора "=>"
                    {
                        i++; // пропускаем вторую часть оператора
                    }
                }
            }

            // Занесение переменных в массив
            char[] variablesArray = variables.ToArray();

            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            string GetOperatorText(int operatorIndex)
            {
                switch (operatorIndex)
                {
                    case 0:
                        return "&";
                    case 1:
                        return "|";
                    case 2:
                        return "!";
                    case 3:
                        return "<=";
                    case 4:
                        return "=>";
                    case 5:
                        return "==";
                    case 6:
                        return ">=";
                    case 7:
                        return "<";
                    case 8:
                        return ">";
                    case 9:
                        return "&&";
                    case 10:
                        return "||";
                    default:
                        return "";
                }
            }

            /////////////////////////////////////////////////////////////////////////////////////


            // Выводим результат в текстовое поле
            textBox2.Text = result.ToString();





            // Определение столбцов и строк таблицы
            //DataGridView dataGridView = new DataGridView();
            dataGridView1.ColumnCount = variableCount + operatorCount + 1; // количество столбцов равно количеству переменных, операторов и столбцу с результатом
            dataGridView1.RowCount = (int)Math.Pow(2, variableCount); // количество строк равно 2^n, где n - количество переменных

            // Создание заголовков столбцов для переменных
            for (int i = 0; i < variablesArray.Length; i++)
            {
                char variableName = (char)(variablesArray[i]); // определение имени переменной (A, B, C и т.д.)
                dataGridView1.Columns[i].HeaderText = variableName.ToString(); // задание имени столбца
            }

            // Создание заголовков столбцов для операторов
            for (int i = variableCount; i < variableCount + operatorCount; i++)
            {
                dataGridView1.Columns[i].HeaderText = GetOperatorText(i - variableCount); // определение имени оператора и задание имени столбца
            }

            // Создание заголовка для столбца с результатом
            dataGridView1.Columns[variableCount + operatorCount].HeaderText = "Результат"; // задание имени столбца


            // Заполнение таблицы значениями
            for (int row = 0; row < dataGridView1.RowCount; row++)
            {
                for (int col = 0; col < dataGridView1.ColumnCount - 1; col++) // последний столбец заполняется отдельно
                {
                    bool value = (((int)(row / Math.Pow(2, col))) % 2 == 0); // определение значения переменной (false или true) в данной строке и данном столбце
                    dataGridView1[col, row].Value = value ? "1" : "0"; // задание значения ячейки в таблице
                }

                // Составляем строку выражения для вычисления ее результата

                for (int i = 0; i < variablesArray.Length; i++)
                {
                    expression += variablesArray[i] + (row % (int)Math.Pow(2, i) < Math.Pow(2, i - 1) ? '\'' : ' ') + " & "; // формирование строки выражения для текущей строки таблицы
                }
                expression = expression.Remove(expression.Length - 3); // удаление последнего оператора "&"

                DataTable dataTable = new DataTable();
                DataRow dataRow = dataTable.NewRow(); // создание новой строки в объекте DataTable
                dataTable.Rows.Add(dataRow); // добавление строки в DataTable

                // Вычисление и задание значения последнего (результирующего) столбца
                dataGridView1[variableCount + operatorCount, row].Value = EvaluateExpression(expression, dataRow, variablesArray) ? "1" : "0";

                dataTable.Rows.Remove(dataRow); // удаление строки из DataTable
            }


        }




        // Метод для подсчета количества переменных в выражении
        private int CountVariables(string expression)
        {
            int count = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (Char.IsLetter(expression[i]) && !Char.IsUpper(expression[i]))
                {
                    count++;
                    while (i < expression.Length && Char.IsLetterOrDigit(expression[i]))
                    {
                        i++;
                    }
                }
            }
            return count;
        }

        // Метод для вычисления значения выражения при заданных значениях переменных
        //    private bool EvaluateExpression(string expression, /*int row1, int variableCount,*/ DataRow row)
        //    {
        //        string[] variables = new string[CountVariables(expression)];
        //        int index = 0;
        //        for (int i = 0; i < expression.Length; i++)
        //        {
        //            if (Char.IsLetter(expression[i]) && !Char.IsUpper(expression[i]))
        //            {
        //                string variable = "";
        //                while (i < expression.Length && Char.IsLetterOrDigit(expression[i]))
        //                {
        //                    variable += expression[i];
        //                    i++;
        //                }
        //                if (!variables.Contains(variable))
        //                {
        //                    variables[index] = variable;
        //                    index++;
        //                }
        //            }
        //        }

        //        // Заменяем переменные на соответствующие значения из строки таблицы
        //        for (int i = 0; i < variables.Length; i++)
        //        {
        //            expression = expression.Replace(variables[i], row[i].ToString());
        //        }

        //        // Вычисляем значение выражения
        //        return LogicalExpressionEvaluator.EvaluateLogicalExpression(expression);
        //    }

        //}


        /////////////////////////////////////////////////////////////////////////////////////////////////////

        private bool EvaluateExpression(string expression, DataRow row, char[] variablesArray)
        {
            // Создаем словарь для хранения значений переменных
            Dictionary<char, bool> variables = new Dictionary<char, bool>();

            // Заполняем словарь значениями переменных из строки таблицы
            for (int i = 0; i < variablesArray.Length; i++)
            {
                variables[variablesArray[i]] = (bool)row[i+1];
            }

            // Заменяем переменные на соответствующие значения из словаря
            foreach (KeyValuePair<char, bool> variable in variables)
            {
                expression = expression.Replace(variable.Key.ToString(), variable.Value.ToString());
            }

            // Вычисляем значение выражения
            return LogicalExpressionEvaluator.EvaluateLogicalExpression(expression);
        }


        private bool EvaluateExpressionRecursive(string expression)
        {
            // Рекурсивно вычисляем значение выражения

            // Базовый случай - если выражение содержит только одно значение (true или false)
            if (expression == "true")
            {
                return true;
            }
            else if (expression == "false")
            {
                return false;
            }

            // Разбиваем выражение на подвыражения и операторы
            List<string> subExpressions = SplitExpression(expression);

            // Вычисляем значение первого подвыражения
            bool leftValue = EvaluateExpressionRecursive(subExpressions[0]);

            // Применяем оператор к левому значению и следующему подвыражению
            for (int i = 1; i < subExpressions.Count - 1; i += 2)
            {
                string op = subExpressions[i];
                bool rightValue = EvaluateExpressionRecursive(subExpressions[i + 1]);

                // Выполняем операцию
                leftValue = ApplyOperator(leftValue, op, rightValue);
            }

            return leftValue;
        }

        private List<string> SplitExpression(string expression)
        {
            // Разбиваем выражение на подвыражения и операторы
            List<string> subExpressions = new List<string>();
            StringBuilder sb = new StringBuilder();
            int parenthesesCount = 0;

            foreach (char c in expression)
            {
                if (c == '(')
                {
                    parenthesesCount++;
                }
                else if (c == ')')
                {
                    parenthesesCount--;
                }

                if (parenthesesCount == 0 && (c == '&' || c == '|'))
                {
                    // Нашли оператор - добавляем текущее подвыражение и оператор в список
                    subExpressions.Add(sb.ToString());
                    sb.Clear();
                    subExpressions.Add(c.ToString());
                }
                else
                {
                    // Добавляем символ в текущее подвыражение
                    sb.Append(c);
                }
            }

            // Добавляем последнее подвыражение
            subExpressions.Add(sb.ToString());

            return subExpressions;
        }

        private bool ApplyOperator(bool leftValue, string op, bool rightValue)
        {
            // Применяем оператор к левому и правому значению
            if (op == "&")
            {
                return leftValue & rightValue;
            }
            else if (op == "|")
            {
                return leftValue | rightValue;
            }

            // Недопустимый оператор - выбрасываем исключение или возвращаем значение по умолчанию
            throw new ArgumentException("Invalid operator: " + op);
        }

        //////////////////////////////////////////////////////////////////////////



        public static class LogicalExpressionEvaluator
        {
            public static bool EvaluateLogicalExpression(string expression)
            {
                // Заменяем символы на соответствующие операции
                expression = expression.Replace("∧", "&&").Replace("∨", "||").Replace("¬", "!").Replace("⊕", "^").Replace("→", "=>").Replace("≡", "==").Replace("←", "<=");
                // Вычисляем выражение
                bool result;
                try
                {
                    result = System.ComponentModel.TypeDescriptor.GetConverter(typeof(bool)).ConvertFromString(expression.Trim()) as bool? ?? false;
                }
                catch
                {
                    result = false;
                }
                return result;

            }
        }
    }
}



