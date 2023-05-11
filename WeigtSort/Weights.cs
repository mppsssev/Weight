
namespace WeigtSort
{
    public class Weights
    {
        private Array weightArray;

        /// <summary>
        /// Initialize array weights
        /// </summary>
        public Weights()
        {
            weightArray = CreateWeight();
        }

        /// <summary>
        /// Only get array weights
        /// </summary>
        /// <value></value>
        public Array WeightArray
        {
            get
            {
                if (weightArray != null)
                    return weightArray;

                else throw new ArgumentNullException();
            }
        }

        private Array CreateWeight()
        {
            var arrayWeght = new[]
            {
                new[] // 210
                {
                    new [] {0, 1},  // 0>1
                    new [] {1, 2},  // 1>2 
                    new [] {0, 2}   // 0>2
                },

                    new[] // 210
                {
                    new [] {0, 1},  // 0>1
                    new [] {1, 2},  // 1>2 
                },

                    new[] // Недостаточно
                {
                    new [] {0, 1},  // 0>1
                    new [] {0, 2}   // 0>2
                },

                    new[] // Ошибка
                {
                    new [] {0, 1},
                    new [] {1, 2},
                    new [] {0, 2},
                    new [] {1, 0}
                },

                new[] //021
                {
                    new [] {1, 0},
                    new [] {1, 2},
                    new [] {2, 0}
                },

                new[] // 021
                {
                    new [] {1, 0},
                    new [] {1, 2},
                    new [] {2, 0},
                    new [] {1, 0}
                }
        };

            return arrayWeght;
        }
        void ShowReadyWeight(Array weights)
        {
            foreach (Array arr in weights)
            {
                PrintListWeight(SortWeight(CalculateCondition(arr)));
            }
        }
        void PrintListWeight(List<int>? list)
        {
            if (list == null) return;

            foreach (var tmp in list)
            {

                Console.Write(tmp + "|");
            }
            Console.Write("\n");
        }


        List<int> SortWeight(Dictionary<int, int> ResultCondition)
        {
            List<int> valuesWeight = new List<int>();
            List<int> result = new List<int>();

            for (int i = 0; i < ResultCondition.Values.Count;)
            {
                int maxValue = ResultCondition.Values.Min();
                valuesWeight.Add(maxValue);
                result.Add(ResultCondition.FirstOrDefault(x => x.Value == maxValue).Key);
                ResultCondition.Remove(result[result.Count - 1]);
            }

            if (СheckWeightScaleOnErrorOrInsufficiency(valuesWeight)) return null;

            return result;


        }

        bool СheckWeightScaleOnErrorOrInsufficiency(List<int> _valuesWeights)
        {
            for (int i = 0; i < _valuesWeights.Count; i++)
            {
                for (int k = i + 1; k < _valuesWeights.Count; k++)
                {
                    if (_valuesWeights[i] == _valuesWeights[k])
                    {
                        if ((_valuesWeights.Max() - _valuesWeights[i]) >= 2)
                        {
                            Console.WriteLine("Insufficiency weighting!");
                            return true;
                        }

                        Console.WriteLine("Error!");
                        return true;
                    }

                }
            }
            return false;
        }



        /// <summary>
        /// Key is name weight, value is scale weight
        /// </summary>
        /// <param name="condWeight"></param>
        /// <returns></returns>
        Dictionary<int, int> CalculateCondition(Array condWeight)
        {
            Dictionary<int, int> weightsScales = new Dictionary<int, int>();

            foreach (Array arrVar in condWeight)
            {
                if (arrVar.Length != 2)
                {
                    Console.WriteLine("Сondition > 2!");
                    break;
                }

                foreach (int i in arrVar)
                {
                    if (weightsScales.ContainsKey(i))
                        continue;

                    weightsScales.Add(i, WeighingScales(i, condWeight));
                }
            }
            return weightsScales;

        }

        int WeighingScales(int i, Array condWeight)
        {
            int countLeft = 0;
            int countRight = 0;

            foreach (Array arrayCheckVar in condWeight)
            {
                if ((int)arrayCheckVar.GetValue(0) == i) countLeft++;

                else if ((int)arrayCheckVar.GetValue(1) == i) countRight++;
            }

            return CalculateMathWeight(countLeft, countRight);
        }

        int CalculateMathWeight(int _countLeft, int _countRight)
        {
            int result = _countLeft - _countRight;
            //Console.WriteLine("result:"+result);
            return result;

        }

        void ShowConsoleAllWeight(Array _weights)
        {
            foreach (Array arrayFill_1 in _weights)
            {
                Console.Write("Сondition:" + Array.IndexOf(_weights, arrayFill_1) + "\n");
                foreach (Array arrayFill_2 in arrayFill_1)
                {

                    foreach (var arrayFill_3 in arrayFill_2)
                    {
                        Console.Write(arrayFill_3);
                    }
                    Console.Write(" ");
                }
                Console.Write("\n \n");
            }
        }


    }
}

