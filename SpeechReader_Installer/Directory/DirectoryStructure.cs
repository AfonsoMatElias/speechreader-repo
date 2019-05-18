using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SpeechReader_Installer
{
	/// <summary>
	/// A helper classe to query information about directoreis
	/// </summary>
	public class DirectoryStructure
	{

        public static List<DirectoryItem>  AllFiles = new List<DirectoryItem>();

		/// <summary>
		/// Get all logical drives in the computer 
		/// </summary>
		/// <returns></returns>
		public static List<DirectoryItem> GetLogicalDrives()
		{
			//Get every logical drives 
			return Directory.GetLogicalDrives().Select(drive => new DirectoryItem { FullPath = drive, Type = DirectoryItemType.Drive }).ToList();
		}

		#region Helpers

		/// <summary>
		/// Find the file or folder name from a full path
		/// </summary>
		/// <param name="path"> the full path</param>
		/// <returns></returns>
		public static string GetFileFolderName(string path)
		{
			//If we have not path, return empty
			if (string.IsNullOrEmpty(path))
				return string.Empty;

			//Make all slashes back slashes
			var normalizedPath = path.Replace('/', '\\');

			//Find the last back slashes
			var lastIndex = normalizedPath.LastIndexOf('\\');

			// if we dont find a back slashes. return the path
			if (lastIndex <= 0)
				return path;

			return path.Substring(lastIndex + 1);
		}

		#endregion


		/// <summary>
		/// Get the directory top level contents
		/// </summary>
		/// <param name="fullPath"></param>
		/// <returns></returns>
		public static List<DirectoryItem> GetDirectoryContents(string fullPath)
		{
			//CReaye a new lis
			var items = new List<DirectoryItem>();

			#region Get Directories

			try
			{
				var dirs = Directory.GetDirectories(fullPath);

                if (dirs.Length > 0)
                    foreach (var d in dirs.Select(dir => new DirectoryItem { Id = DirectoryItem.mId++, FullPath = dir, Type = DirectoryItemType.Folder })) {
                        items.Add(d);
                        items.AddRange(GetDirectoryContents(d.FullPath));
                    }

			}
			catch { }
			
			#endregion

			#region Get Files


			try
			{
				var f = Directory.GetFiles(fullPath);

				if (f.Length > 0)
					items.AddRange(f.Select(file => new DirectoryItem { Id = DirectoryItem.mId++, FullPath = file, Type = DirectoryItemType.File }));

			}
			catch { }

            #endregion

            if(items.Count > 0)
                foreach(var item in items)
                    if(!AllFiles.Contains(item))
                        AllFiles.Add(item);

			return items;
		}
	}
}
