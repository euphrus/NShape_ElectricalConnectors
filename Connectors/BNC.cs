using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class BNC : RectangleFBase
	{

		#region Constructors

		protected internal BNC(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			Width = 11.91F;
			Height = 9.91F;
		}

		protected internal BNC(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			Width = 11.91F;
			Height = 9.91F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new BNC(Type, Template);
			result.CopyFrom(this);
			return result;
		}

		protected override bool CalculatePath()
		{
			if (base.CalculatePath())
			{
				Path.Reset();
				Path.Reset();
				Path.AddPolygon(new PointF[]
				{
					new PointF(-4.905F * Scale, -4.905F * -1 * Scale), 
					new PointF(-4.905F * Scale, -0.5F * -1 * Scale), 
					new PointF(-5.905F * Scale, -0.5F * -1 * Scale), 
					new PointF(-5.905F * Scale, 0.5F * -1 * Scale), 
					new PointF(-4.905F * Scale, 0.5F * -1 * Scale), 
					new PointF(-4.905F * Scale, 4.905F * -1 * Scale), 
					new PointF(4.905F * Scale, 4.905F * -1 * Scale), 
					new PointF(4.905F * Scale, 0.5F * -1 * Scale), 
					new PointF(5.905F * Scale, 0.5F * -1 * Scale), 
					new PointF(5.905F * Scale, -0.5F * -1 * Scale), 
					new PointF(4.905F * Scale, -0.5F * -1 * Scale), 
					new PointF(4.905F * Scale, -4.905F * -1 * Scale)
				});
				Path.AddArc(-4.905F * Scale, 4.905F * -1 * Scale, 9.81F * Scale, 9.81F * Scale, 180F, 360F);
				Path.AddArc(-4.905F * Scale, 4.905F * -1 * Scale, 9.81F * Scale, 9.81F * Scale, 180F, 360F);
				Path.AddArc(-4.05F * Scale, 4.05F * -1 * Scale, 8.1F * Scale, 8.1F * Scale, 180F, 360F);
				Path.AddArc(-4.05F * Scale, 4.05F * -1 * Scale, 8.1F * Scale, 8.1F * Scale, 180F, 360F);
				Path.AddArc(-2.415F * Scale, 2.415F * -1 * Scale, 4.83F * Scale, 4.83F * Scale, 180F, 360F);
				Path.AddArc(-2.415F * Scale, 2.415F * -1 * Scale, 4.83F * Scale, 4.83F * Scale, 180F, 360F);
				Path.AddArc(-0.66F * Scale, 0.66F * -1 * Scale, 1.32F * Scale, 1.32F * Scale, 180F, 360F);
				Path.AddArc(-0.66F * Scale, 0.66F * -1 * Scale, 1.32F * Scale, 1.32F * Scale, 180F, 360F);
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("BNC", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new BNC(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.BNC);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			Width = 11.91F;
			Height = 9.91F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int BNCMiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.BNCMiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.BNCMiddleCenter);
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
				case ControlPointIds.BNCMiddleCenter:
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
