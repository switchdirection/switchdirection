namespace TaskFromManualHomeWork16.Model
{
    public class ProductModel
    {
		private int _productId;

		public int ProductId
		{
			get { return _productId; }
			set { _productId = value; }
		}

		private string _productName;

		public string ProductName
		{
			get { return _productName; }
			set { _productName = value; }
		}

		private int _productAmount;

		public int ProductAmount
		{
			get { return _productAmount; }
			set { _productAmount = value; }
		}

		private string _category;

		public string Category
		{
			get { return _category; }
			set { _category = value; }
		}



	}
}
