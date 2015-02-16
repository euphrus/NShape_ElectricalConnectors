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

		private float _widthF;
		private float _heightF;
		protected const float _pixelToMmMultiple = 3.779528F;

		#endregion Fields

		#region Constructors

		protected internal RectangleFBase(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
		}

		protected internal RectangleFBase(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
		}

		#endregion Constructors

		#region Required Methods

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			WidthF = 10F;
			HeightF = 10F;
		}

		#endregion Required Methods

		#region Properties

		[Browsable(false)]
		public float WidthF
		{
			get
			{
				return _widthF;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("Value must be greater than zero", "Width");
				}
				if (_widthF != value)
				{
					_widthF = value;
					Width = (int)Math.Ceiling(_widthF * _pixelToMmMultiple * Scale);
				}
			}
		}

		private new int Width
		{
			get
			{
				return base.Width;
			}
			set
			{
				base.Width = value;
			}
		}

		[Browsable(false)]
		public float HeightF
		{
			get
			{
				return _heightF * Scale * _pixelToMmMultiple;
			}
			set
			{
				if (value < 0)
				{
					throw new ArgumentException("Value must be greater than zero", "Height");
				}
				if (_heightF != value)
				{
					_heightF = value;
					Height = (int)Math.Ceiling(_heightF * _pixelToMmMultiple * Scale);
				}
			}
		}

		private new int Height
		{
			get
			{
				return base.Height;
			}
			set
			{
				base.Height = value;
			}
		}

		private float _scale;
		[Browsable(true)]
		[Category("Layout")]
		public float Scale
		{
			get
			{
				if (_scale <= 0)
				{
					_scale = 1F;
				}
				return _scale;
			}
			set
			{
				if (value > 0)
				{
					_scale = value;
					base.Width = (int)Math.Ceiling(_widthF * Scale * _pixelToMmMultiple);
					base.Height = (int)Math.Ceiling(_heightF * Scale * _pixelToMmMultiple);
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
