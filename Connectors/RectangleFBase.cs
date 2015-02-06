using System;
using System.ComponentModel;
using System.Drawing;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public abstract class RectangleFBase : RectangleBase
	{

		#region Fields

		private float _width;
		private float _height;
		protected const float _pixelToMmMultiple = 3.779528F;

		#endregion Fields

		#region Constructors

		protected internal RectangleFBase(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			Scale = 1F;
			Width = 10F;
			Height = 10F;
		}

		protected internal RectangleFBase(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			Scale = 1F;
			Width = 10F;
			Height = 10F;
		}

		#endregion Constructors

		#region Required Methods

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			Width = 10F;
			Height = 10F;
		}

		#endregion Required Methods

		#region Properties

		[Browsable(false)]
		public new float Width
		{
			get
			{
				return _width * Scale * _pixelToMmMultiple;
			}
			set
			{
				_width = value;
				base.Width = (int)Math.Ceiling(_width * Scale * _pixelToMmMultiple);
			}
		}

		[Browsable(false)]
		public new float Height
		{
			get
			{
				return _height * Scale * _pixelToMmMultiple;
			}
			set
			{
				_height = value;
				base.Height = (int)Math.Ceiling(_height * Scale * _pixelToMmMultiple);
			}
		}

		private float _scale;
		[Browsable(true)]
		[Category("Layout")]
		public float Scale
		{
			get
			{
				return _scale;
			}
			set
			{
				if (value > 0)
				{
					_scale = value;
					base.Width = (int)Math.Ceiling(_width * Scale * _pixelToMmMultiple);
					base.Height = (int)Math.Ceiling(_height * Scale * _pixelToMmMultiple);
				}
			}
		}

		#endregion Properties

		protected static void AddChildShape(PathBasedPlanarShape parentShape, PathBasedPlanarShape childShape, string colorName, Color baseColor, Color secondaryColor)
		{
			childShape.FillStyle = new FillStyle(colorName,
				new ColorStyle(baseColor.Name, baseColor),
				new ColorStyle(secondaryColor.Name, secondaryColor));
			if (!parentShape.Children.Contains(childShape))
			{
				parentShape.Children.Add(childShape);
			}
		}

	}
}
