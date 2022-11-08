namespace KSPHelperApp
{
    internal class Transfer
    {
        public String  Name { get; set; }
        public int Value { get; set; }
        public List<Transfer>? Transfers { get; set; }

        public Transfer(String name, int value)
        {
            this.Name = name;
            this.Value = value;
        }

        public Transfer(String name, int value, List<Transfer> transfers)
        {
            this.Name = name;
            this.Value = value;
            this.Transfers = transfers;
        }

        public Transfer AddTransfer(Transfer t)
        {
            Transfers ??= new List<Transfer>();
            Transfers.Add(t);
            return this;
        }
    }
}