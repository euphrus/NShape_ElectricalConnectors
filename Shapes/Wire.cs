using System.Collections.Generic;
using System.Drawing;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.NShape.Ports
{

	public class Wire : RectangleFBase
	{

		public enum MemberShape
		{
			EarthGround,
			Jumper,
			WireWrap
		}

		private MemberShape _member;
		public MemberShape Member
		{
			get
			{
				return _member;
			}
			set
			{
				if (_member != value)
				{
					_member = value;
					Invalidate();
					InvalidateDrawCache();
				}
			}
		}

		#region Constructors

		protected internal Wire(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			WidthF = 10F;
			HeightF = 60F;
		}

		protected internal Wire(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			WidthF = 10F;
			HeightF = 60F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new Wire(Type, Template);
			result.CopyFrom(this);
			return result;
		}

		protected override bool CalculatePath()
		{
			if (base.CalculatePath())
			{
				Path.Reset();
				switch (Member)
				{
					case MemberShape.EarthGround:
						EarthGroundPath();
						break;
					case MemberShape.Jumper:
						JumperPath();
						break;
					case MemberShape.WireWrap:
						WireWrapPath();
						break;
				}
				return true;
			}
			return false;
		}

		private void EarthGroundPath()
		{
			WidthF = 10F;
			HeightF = 60F;
			Path.AddRectangle(new RectangleF(-5F * Scale * _pixelToMmMultiple, 30F * -1 * Scale * _pixelToMmMultiple, 10F * Scale * _pixelToMmMultiple, 60F * Scale * _pixelToMmMultiple));
		}

		private void JumperPath()
		{
			WidthF = 5F;
			HeightF = 2F;
			Path.AddRectangle(new RectangleF(-2.5F * Scale * _pixelToMmMultiple, 1F * -1 * Scale * _pixelToMmMultiple, 5F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-1.595F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(0.945F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple));
		}

		private void WireWrapPath()
		{
			WidthF = 20F;
			HeightF = 2F;
			Path.AddRectangle(new RectangleF(-10F * Scale * _pixelToMmMultiple, 1F * -1 * Scale * _pixelToMmMultiple, 20F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-9.215F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-6.675F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-4.135F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-1.595F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(0.945F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(3.485F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(6.025F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(8.565F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple));
			Path.AddArc(-9.215F * Scale * _pixelToMmMultiple, 0.3175F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-6.675F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-4.135F * Scale * _pixelToMmMultiple, 0.3255F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-1.595F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(0.945F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(3.485F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(6.025F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(8.565F * Scale * _pixelToMmMultiple, 0.325F * -1 * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 0.65F * Scale * _pixelToMmMultiple, 180F, 360F);
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "Ports";
			return new ShapeType("Wire", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new Wire(s, t); },
			Wire.GetPropertyDefinitions, Windstream.NShape.Ports.Properties.Resources.Wire);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			WidthF = 10F;
			HeightF = 60F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int WireMiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.WireMiddleCenter] = Point.Empty;
		}

		public override IEnumerable<ControlPointId> GetControlPointIds(ControlPointCapabilities controlPointCapability)
		{
			List<ControlPointId> returnValue = new List<ControlPointId>();
			if ((controlPointCapability & ControlPointCapabilities.Rotate) != 0)
			{
				returnValue.Add(ControlPointIds.MiddleCenter);
				returnValue.Add(ControlPointIds.Reference);
			}
			if ((controlPointCapability & ControlPointCapabilities.Connect) != 0)
			{
				returnValue.Add(ControlPointIds.WireMiddleCenter);
			}
			return returnValue;
		}

		public override Point GetControlPointPosition(ControlPointId controlPointId)
		{
			return ControlPoints[controlPointId];
		}

		public override bool HasControlPointCapability(ControlPointId controlPointId, ControlPointCapabilities controlPointCapability)
		{
			bool returnValue = false;
			switch (controlPointId)
			{
				case ControlPointIds.MiddleCenter:
				case ControlPointId.Reference:
					returnValue = (controlPointCapability & ControlPointCapabilities.Rotate) != 0;
					break;
				case ControlPointIds.WireMiddleCenter:
					returnValue = (controlPointCapability & ControlPointCapabilities.Connect) != 0;
					break;
			}
			return returnValue;
		}

		private const int _controlPointCount = 3;
		protected override int ControlPointCount
		{
			get
			{
				return _controlPointCount;
			}
		}

		#endregion ControlPoints

		new public static IEnumerable<EntityPropertyDefinition> GetPropertyDefinitions(int version)
		{
			foreach (EntityPropertyDefinition pi in RectangleFBase.GetPropertyDefinitions(version))
			{
				yield return pi;
			}
		}

		protected override void LoadFieldsCore(IRepositoryReader reader, int version)
		{
			base.LoadFieldsCore(reader, version);
		}

		protected override void SaveFieldsCore(IRepositoryWriter writer, int version)
		{
			base.SaveFieldsCore(writer, version);
		}

	}
}