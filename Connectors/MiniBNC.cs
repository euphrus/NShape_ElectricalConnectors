using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class MiniBNC : RectangleFBase
	{

		#region Constructors

		protected internal MiniBNC(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			Width = 8.54F;
			Height = 7.54F;
		}

		protected internal MiniBNC(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			Width = 8.54F;
			Height = 7.54F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new MiniBNC(Type, Template);
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
					new PointF(-3.77F * Scale, -3.77F * -1 * Scale), 
					new PointF(-3.77F * Scale, -0.5F * -1 * Scale), 
					new PointF(-4.27F * Scale, -0.5F * -1 * Scale), 
					new PointF(-4.27F * Scale, 0.5F * -1 * Scale), 
					new PointF(-3.77F * Scale, 0.5F * -1 * Scale), 
					new PointF(-3.77F * Scale, 3.77F * -1 * Scale), 
					new PointF(3.77F * Scale, 3.77F * -1 * Scale), 
					new PointF(3.77F * Scale, 0.5F * -1 * Scale), 
					new PointF(4.27F * Scale, 0.5F * -1 * Scale), 
					new PointF(4.27F * Scale, -0.5F * -1 * Scale), 
					new PointF(3.77F * Scale, -0.5F * -1 * Scale), 
					new PointF(3.77F * Scale, -3.77F * -1 * Scale)
				});
				Path.AddArc(-3.745F * Scale, 3.745F * -1 * Scale, 7.49F * Scale, 7.49F * Scale, 180F, 360F);
				Path.AddArc(-0.5F * Scale, 0.5F * -1 * Scale, 1F * Scale, 1F * Scale, 180F, 360F);
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("MiniBNC", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new MiniBNC(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.MiniBNC);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			Width = 8.54F;
			Height = 7.54F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int MiniBNCMiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.MiniBNCMiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.MiniBNCMiddleCenter);
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
				case ControlPointIds.MiniBNCMiddleCenter:
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
