using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class IEC60320_C10 : RectangleFBase
	{

		#region Constructors

		protected internal IEC60320_C10(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			Width = 25.5F;
			Height = 17.5F;
		}

		protected internal IEC60320_C10(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			Width = 25.5F;
			Height = 17.5F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new IEC60320_C10(Type, Template);
			result.CopyFrom(this);
			return result;
		}

		protected override bool CalculatePath()
		{
			if (base.CalculatePath())
			{
				Path.Reset();
				Path.Reset();
				Path.AddArc(-12.75F * Scale, 8.75F * -1 * Scale, 2.5F * Scale, 2.5F * Scale, 180F, 90F);
				Path.AddArc(10.25F * Scale, 8.75F * -1 * Scale, 2.5F * Scale, 2.5F * Scale, 270F, 90F);
				Path.AddArc(10.25F * Scale, -6.25F * -1 * Scale, 2.5F * Scale, 2.5F * Scale, 360F, 90F);
				Path.AddArc(-12.75F * Scale, -6.25F * -1 * Scale, 2.5F * Scale, 2.5F * Scale, 90F, 90F);
				Path.CloseFigure();
				Path.AddArc(-10.5F * Scale, 6.5F * -1 * Scale, 2.5F * Scale, 2.5F * Scale, 180F, 90F);
				Path.AddArc(8F * Scale, 6.5F * -1 * Scale, 2.5F * Scale, 2.5F * Scale, 270F, 90F);
				Path.AddArc(8F * Scale, -4F * -1 * Scale, 2.5F * Scale, 2.5F * Scale, 360F, 90F);
				Path.AddArc(-10.5F * Scale, -4F * -1 * Scale, 2.5F * Scale, 2.5F * Scale, 90F, 90F);
				Path.CloseFigure();
				Path.AddPolygon(new PointF[]
				{
					new PointF(-6F * Scale, -2F * -1 * Scale), 
					new PointF(-6F * Scale, 2F * -1 * Scale), 
					new PointF(-4F * Scale, 2F * -1 * Scale), 
					new PointF(-4F * Scale, -2F * -1 * Scale)
				});
				Path.AddPolygon(new PointF[]
				{
					new PointF(-5.5F * Scale, -1.65F * -1 * Scale), 
					new PointF(-5.5F * Scale, 1.65F * -1 * Scale), 
					new PointF(-4.5F * Scale, 1.65F * -1 * Scale), 
					new PointF(-4.5F * Scale, -1.65F * -1 * Scale)
				});
				Path.AddPolygon(new PointF[]
				{
					new PointF(6F * Scale, -2F * -1 * Scale), 
					new PointF(4F * Scale, -2F * -1 * Scale), 
					new PointF(4F * Scale, 2F * -1 * Scale), 
					new PointF(6F * Scale, 2F * -1 * Scale)
				});
				Path.AddPolygon(new PointF[]
				{
					new PointF(4.5F * Scale, -1.65F * -1 * Scale), 
					new PointF(4.5F * Scale, 1.65F * -1 * Scale), 
					new PointF(5.5F * Scale, 1.65F * -1 * Scale), 
					new PointF(5.5F * Scale, -1.65F * -1 * Scale)
				});
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("IEC60320_C10", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new IEC60320_C10(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.IEC60320_C10);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			Width = 25.5F;
			Height = 17.5F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int IEC60320_C10MiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.IEC60320_C10MiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.IEC60320_C10MiddleCenter);
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
				case ControlPointIds.IEC60320_C10MiddleCenter:
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
