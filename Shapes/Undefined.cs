using System.Collections.Generic;
using System.Drawing;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.NShape.Ports
{

	public class Undefined : RectangleFBase
	{

		public enum MemberShape
		{
			RJ21
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

		protected internal Undefined(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			WidthF = 82.6F;
			HeightF = 15F;
		}

		protected internal Undefined(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			WidthF = 82.6F;
			HeightF = 15F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new Undefined(Type, Template);
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
					case MemberShape.RJ21:
						RJ21Path();
						break;
				}
				return true;
			}
			return false;
		}

		private void RJ21Path()
		{
			WidthF = 82.6F;
			HeightF = 15F;
			Path.AddArc(-41.3F * Scale * _pixelToMmMultiple, 2F * -1 * Scale * _pixelToMmMultiple, 4F * Scale * _pixelToMmMultiple, 4F * Scale * _pixelToMmMultiple, 145F, 70F);
			Path.AddLines(new PointF[]{new PointF(-35F * Scale * _pixelToMmMultiple, 7.5F * -1 * Scale * _pixelToMmMultiple), new PointF(35F * Scale * _pixelToMmMultiple, 7.5F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddArc(37.3F * Scale * _pixelToMmMultiple, 2F * -1 * Scale * _pixelToMmMultiple, 4F * Scale * _pixelToMmMultiple, 4F * Scale * _pixelToMmMultiple, 305F, 70F);
			Path.AddLines(new PointF[]{new PointF(35F * Scale * _pixelToMmMultiple, -7.5F * -1 * Scale * _pixelToMmMultiple), new PointF(-35F * Scale * _pixelToMmMultiple, -7.5F * -1 * Scale * _pixelToMmMultiple)});
			Path.CloseFigure();
			Path.AddArc(-40F * Scale * _pixelToMmMultiple, 1.1F * -1 * Scale * _pixelToMmMultiple, 2.2F * Scale * _pixelToMmMultiple, 2.2F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(37.8F * Scale * _pixelToMmMultiple, 1.1F * -1 * Scale * _pixelToMmMultiple, 2.2F * Scale * _pixelToMmMultiple, 2.2F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-32.32F * Scale * _pixelToMmMultiple, 6.125F * -1 * Scale * _pixelToMmMultiple, 4F * Scale * _pixelToMmMultiple, 4F * Scale * _pixelToMmMultiple, 180F, 90F);
			Path.AddArc(28.32F * Scale * _pixelToMmMultiple, 6.125F * -1 * Scale * _pixelToMmMultiple, 4F * Scale * _pixelToMmMultiple, 4F * Scale * _pixelToMmMultiple, 270F, 90F);
			Path.AddArc(26.32F * Scale * _pixelToMmMultiple, -2.125F * -1 * Scale * _pixelToMmMultiple, 4F * Scale * _pixelToMmMultiple, 4F * Scale * _pixelToMmMultiple, 10F, 90F);
			Path.AddArc(-30.32F * Scale * _pixelToMmMultiple, -2.125F * -1 * Scale * _pixelToMmMultiple, 4F * Scale * _pixelToMmMultiple, 4F * Scale * _pixelToMmMultiple, 80F, 90F);
			Path.CloseFigure();
			Path.AddRectangle(new RectangleF(-25.92F * Scale * _pixelToMmMultiple, 1F * -1 * Scale * _pixelToMmMultiple, 51.84F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple));
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "Ports";
			return new ShapeType("Undefined", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new Undefined(s, t); },
			Undefined.GetPropertyDefinitions, Windstream.NShape.Ports.Properties.Resources.Undefined);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			WidthF = 82.6F;
			HeightF = 15F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int UndefinedMiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.UndefinedMiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.UndefinedMiddleCenter);
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
				case ControlPointIds.UndefinedMiddleCenter:
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