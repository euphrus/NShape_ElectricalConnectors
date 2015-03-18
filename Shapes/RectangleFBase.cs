using System;
using System.Collections.Generic;
using System.ComponentModel;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.NShape.Ports
{

	public abstract class RectangleFBase : RectangleBase
	{

		#region Fields

		private float _scale;
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

		[Browsable(false)]
		new public int Width
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
		new public int Height
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

		[Category("Layout")]
		[Browsable(true)]
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

		new public static IEnumerable<EntityPropertyDefinition> GetPropertyDefinitions(int version)
		{
			foreach (EntityPropertyDefinition pi in RectangleBase.GetPropertyDefinitions(version))
			{
				yield return pi;
			}
			yield return new EntityFieldDefinition("Scale", typeof(float));
		}

		protected override void LoadFieldsCore(IRepositoryReader reader, int version)
		{
			base.LoadFieldsCore(reader, version);
			Scale = reader.ReadFloat();
		}

		protected override void SaveFieldsCore(IRepositoryWriter writer, int version)
		{
			base.SaveFieldsCore(writer, version);
			writer.WriteFloat(Scale);
		}

	}
}