namespace WeigtSort;

public class Weights
{


    private Array CreateWeight()
    {

        var arrayWeght = new []
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

}

