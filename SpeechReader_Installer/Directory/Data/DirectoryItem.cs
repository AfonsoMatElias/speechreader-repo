namespace SpeechReader_Installer
{
	/// <summary>
	/// INformation about a directory
	/// </summary>
	public class DirectoryItem
	{
        public int Id { get; set; }

        public static int mId = 0;
		/// <summary>
		/// The Type of this item
		/// </summary>
		public DirectoryItemType Type { get; set; }

		/// <summary>
		/// The of the item
		/// </summary>
		public string Name { get { return this.Type == DirectoryItemType.Drive ? this.FullPath : DirectoryStructure.GetFileFolderName(FullPath); } }

		/// <summary>
		/// The absolute path to this item 
		/// </summary>
		public string FullPath { get; set; }
	}
}
