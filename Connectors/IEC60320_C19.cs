using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class IEC60320_C19 : RectangleFBase
	{

		#region Constructors

		protected internal IEC60320_C19(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			Width = 35F;
			Height = 27F;
		}

		protected internal IEC60320_C19(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			Width = 35F;
			Height = 27F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new IEC60320_C19(Type, Template);
			result.CopyFrom(this);
			return result;
		}

		protected override bool CalculatePath()
		{
			if (base.CalculatePath())
			{
				Path.Reset();
				Path.Reset();
				Path.AddRectangle(new RectangleF(-17.5F * Scale, 13.5F * -1 * Scale, 35F * Scale, 27F * Scale));
				Path.AddLines(new PointF[]{new PointF(-14F * Scale, 3F * -1 * Scale), new PointF(-6.221826F * Scale, 10F * -1 * Scale), new PointF(6.221826F * Scale, 10F * -1 * Scale), new PointF(14F * Scale, 3F * -1 * Scale)});
				Path.AddArc(10.5F * Scale, -6.5F * -1 * Scale, 3.5F * Scale, 3.5F * Scale, 360F, 90F);
				Path.AddArc(-14F * Scale, -6.5F * -1 * Scale, 3.5F * Scale, 3.5F * Scale, 90F, 90F);
				Path.CloseFigure();
				Path.AddRectangle(new RectangleF(-10F * Scale, -2.75F * -1 * Scale, 7F * Scale, 2.5F * Scale));
				Path.AddRectangle(new RectangleF(-3.5F * Scale, 5.25F * -1 * Scale, 7F * Scale, 2.5F * Scale));
				Path.AddRectangle(new RectangleF(3F * Scale, -2.75F * -1 * Scale, 7F * Scale, 2.5F * Scale));
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("IEC60320_C19", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new IEC60320_C19(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.IEC60320_C19);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			Width = 35F;
			Height = 27F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int IEC60320_C19MiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.IEC60320_C19MiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.IEC60320_C19MiddleCenter);
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
				case ControlPointIds.IEC60320_C19MiddleCenter:
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

	}
}
