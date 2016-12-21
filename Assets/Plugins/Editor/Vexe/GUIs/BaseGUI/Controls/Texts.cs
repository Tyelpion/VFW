using UnityEngine;

namespace Vexe.Editor.GUIs
{
	public abstract partial class BaseGUI
	{
		public string TextField(string value)
		{
			return TextField(string.Empty, value);
		}

		public string TextField(string label, string value)
		{
			return TextField(label, value, Layout.Auto);
		}

		public string TextField(string value, Layout option)
		{
			return TextField(GUIContent.none, value, option);
		}

		public string TextField(string label, string value, Layout option)
		{
			return TextField(label, value, string.Empty, option);
		}

		public string TextField(string label, string value, string tooltip)
		{
			return TextField(label, value, tooltip, Layout.Auto);
		}

		public string TextField(string label, string value, string tooltip, Layout option)
		{
			return TextField(GetContent(label, tooltip), value, option);
		}

		public string TextField(GUIContent content, string value, Layout option)
		{
			return TextField(content, value, GUIStyles.TextField, option);
		}

		public abstract string TextField(GUIContent content, string value, GUIStyle style, Layout option);

		public string ToolbarSearch(string value)
		{
			return ToolbarSearch(value, null);
		}

		public abstract string ToolbarSearch(string value, Layout option);

		public string TextArea(string value)
		{
			return TextArea(value, null);
		}

		public abstract string TextArea(string value, Layout option);

		public string ScrollableTextArea(string value, ref Vector2 scrollPos, Layout option)
		{
			return ScrollableTextArea(value, ref scrollPos, GUIStyles.TextArea, option);
		}

		public abstract string ScrollableTextArea(string value, ref Vector2 scrollPos, GUIStyle style, Layout option);
	}
}
