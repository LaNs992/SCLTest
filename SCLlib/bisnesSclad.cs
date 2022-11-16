using склад;
namespace SCLlib
{
    public class bisnesSclad
    {

        private List<sclad> ScldBL = new List<sclad>();

        public bisnesSclad() { }
        public List<sclad> Get()
        {
            return ScldBL;
        }

        public void Add(sclad data)
        {
            ScldBL.Add(data);
        }
        public void Remove(sclad data)
        {
            ScldBL.Remove(data);
        }

        public void Update(sclad id, sclad data)
        {
            var index = ScldBL.IndexOf(id);
            ScldBL[index] = data;
        }
    }
}