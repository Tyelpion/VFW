using UnityEngine;
using Vexe.Runtime.Types;

namespace VFWExamples
{
	/// <summary>
	/// A small demo for exposing methods in the inspector
	/// Notes: The arguments you set to the method in the editor won't survive assembly reloads
	/// </summary>
	public class ShowExample : BaseBehaviour
	{
		[Show]
		public void Method0()
		{
			LogFormat("void - no params");
		}

		[Show]
		public void Method1(string arg0)
		{
			name = arg0;
		}

		[Show]
		public int Method2(Transform arg0)
		{
			LogFormat("returning " + arg0.name + " children count: " + arg0.childCount);
			return arg0.childCount;
		}

		private string[] ItemNames
		{
			get
			{
				return new string[]
				{
					  "Shotgun",
					  "SomeAmmo",
					  "MansionKey",
					  "etc"
				};
			}
		}

		[Show]
		private void Method3(
			[StringPopup("ItemNames")] string item,
			[Tags, FilterTags] string tag,
			[SelectEnum] KeyCode key)
		{
			Log(item);
			Log(tag);
			Log(key);
		}
	}
}
