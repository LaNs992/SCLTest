using SCLlib;
using �����;

namespace ScladLogic
{
    public class UnitTest1
    {
        [Fact]
        public void AddButton()
        {
            bisnesSclad SCL = new();
            var result = SCL.Get();
            sclad mytest = new()
            {
               name = "�������",
                raz = "13",
                mater = "������",
                kol = 100,
                min = 2,
                price = 234,
                fulprice = 280.4 ,
           
            };
            SCL.Add(mytest);
            Assert.Equal(mytest, result[0]);
        }

        [Fact]
        public void ChangeButton()
        {
            bisnesSclad SCL = new();
            var result = SCL.Get();
            sclad mytest = new()
            {
                name = "����",
                raz = "13",
                mater = "������",
                kol = 100,
                min = 2,
                price = 234,
                fulprice = 280.4,
            };
            SCL.Add(mytest);
            sclad mytest2 = new()
            {
                name = "�������",
                raz = "13",
                mater = "������",
                kol = 70,
                min = 2,
                price = 234,
                fulprice = 280.4,
            };
            SCL.Update(mytest,mytest2);
            Assert.Equal(mytest2, result[0]);
        }

        [Fact]
        public void DeleteButton()
        {
            bisnesSclad SCL = new();
            var result = SCL.Get();
            sclad mytest = new()
            {

                name = "����",
                raz = "13",
                mater = "������",
                kol = 100,
                min = 2,
                price = 234,
                fulprice = 280.4,
            };
            SCL.Add(mytest);
            SCL.Remove(mytest);
            Assert.Empty(result);
        }
    }
}