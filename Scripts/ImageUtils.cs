using UnityEngine;
using UnityEngine.UI;

namespace Kogane
{
	public static class ImageUtils
	{
		/// <summary>
		/// <para>Tiled な Image の sprite に border が設定されておらず、</para>
		/// <para>なおかつ Texture の WrapMode が Repeat になっていない</para>
		/// <para>もしくは SpriteAtlas でパッキングされる場合 true を返します</para>
		///	<para></para>
		/// <para>Inspector に下記の警告が出る条件です</para>
		///	<para></para>
		/// <para>It looks like you want to tile a sprite with no border.</para>
		/// <para>It would be more efficient to modify the Sprite properties,</para>
		/// <para>clear the Packing tag and set the Wrap mode to Repeat.</para>
		/// </summary>
		public static bool IsTiledWithNoBorder( Image image )
		{
			return
				image.type == Image.Type.Tiled &&
				image.sprite != null &&
				!image.hasBorder &&
				( image.sprite.texture.wrapMode != TextureWrapMode.Repeat || image.sprite.packed )
				;
		}
	}
}