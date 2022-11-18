using SCLlib;
using склад;

namespace ScladLogic
{
    public class UnitTest1
    {
        [Fact]
        public void AddButton()
        {
            bisnesSclad SCL = new();    
            sclad mytest = new()
            {
               name = "Сумка",
                raz = "13",
                mater = "медь",
                kol = 100,
                min = 2,
                price = 234,
                fulprice = 280.4 ,
           
            };
            SCL.Add(mytest);
            var result = SCL.Get();
            Assert.Equal(mytest, result[0]);
        }

        [Fact]
        public void ChangeButton()
        {
            bisnesSclad SCL = new();
           
            sclad mytest = new()
            {
                name = "Сумка",
                raz = "13",
                mater = "медь",
                kol = 100,
                min = 2,
                price = 234,
                fulprice = 280.4,
            };
            SCL.Add(mytest);
            sclad mytest2 = new()
            {
                name = "Карандаш",
                raz = "13",
                mater = "Дерево",
                kol = 70,
                min = 2,
                price = 234,
                fulprice = 280.4,
            };
            SCL.Update(mytest,mytest2);
             var result = SCL.Get();
            Assert.Equal(mytest2, result[0]);
        }

        [Fact]
        public void DeleteButton()
        {
            bisnesSclad SCL = new();
            sclad mytest = new()
            {

                name = "Сумка",
                raz = "13",
                mater = "медь",
                kol = 100,
                min = 2,
                price = 234,
                fulprice = 280.4,
            };
            SCL.Add(mytest);
            SCL.Remove(mytest);
             var result = SCL.Get();
            Assert.Empty(result);
        }
    }
}
