using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class MU : RectangleFBase
	{

		#region Constructors

		protected internal MU(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			Width = 6.6F;
			Height = 4.4F;
		}

		protected internal MU(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			Width = 6.6F;
			Height = 4.4F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new MU(Type, Template);
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
					new PointF(-3.3F * Scale, -2.2F * -1 * Scale), 
					new PointF(-3.3F * Scale, 1.75F * -1 * Scale), 
					new PointF(-2.3F * Scale, 1.75F * -1 * Scale), 
					new PointF(-1.8F * Scale, 2.2F * -1 * Scale), 
					new PointF(1.8F * Scale, 2.2F * -1 * Scale), 
					new PointF(2.3F * Scale, 1.75F * -1 * Scale), 
					new PointF(3.3F * Scale, 1.75F * -1 * Scale), 
					new PointF(3.3F * Scale, -2.2F * -1 * Scale), 
					new PointF(-2.7F * Scale, -2.2F * -1 * Scale)
				});
				Path.AddRectangle(new RectangleF(-3.3F * Scale, 0.8F * -1 * Scale, 0.8F * Scale, 1.6F * Scale));
				Path.AddRectangle(new RectangleF(2.5F * Scale, 0.8F * -1 * Scale, 0.8F * Scale, 1.6F * Scale));
				Path.AddRectangle(new RectangleF(2.5F * Scale, 0.75F * -1 * Scale, 0.095F * Scale, 1.5F * Scale));
				Path.AddRectangle(new RectangleF(-2.6F * Scale, 0.75F * -1 * Scale, 0.095F * Scale, 1.5F * Scale));
				Path.AddRectangle(new RectangleF(2.7F * Scale, 1.75F * -1 * Scale, 0.6F * Scale, 0.45F * Scale));
				Path.AddRectangle(new RectangleF(-3.3F * Scale, 1.75F * -1 * Scale, 0.6F * Scale, 0.45F * Scale));
				Path.AddRectangle(new RectangleF(-3.3F * Scale, -1.3F * -1 * Scale, 0.6F * Scale, 0.9F * Scale));
				Path.AddRectangle(new RectangleF(2.7F * Scale, -1.3F * -1 * Scale, 0.6F * Scale, 0.9F * Scale));
				Path.AddRectangle(new RectangleF(-3.3F * Scale, 1.3F * -1 * Scale, 0.8F * Scale, 0.5F * Scale));
				Path.AddRectangle(new RectangleF(2.5F * Scale, 1.3F * -1 * Scale, 0.8F * Scale, 0.5F * Scale));
				Path.AddRectangle(new RectangleF(-3.3F * Scale, -0.8F * -1 * Scale, 0.8F * Scale, 0.5F * Scale));
				Path.AddRectangle(new RectangleF(2.5F * Scale, -0.8F * -1 * Scale, 0.8F * Scale, 0.5F * Scale));
				Path.AddArc(-0.625F * Scale, 0.625F * -1 * Scale, 1.25F * Scale, 1.25F * Scale, 180F, 360F);
				Path.AddArc(-0.3F * Scale, 0.3F * -1 * Scale, 0.6F * Scale, 0.6F * Scale, 180F, 360F);
				Path.AddArc(-2.1F * Scale, 2.1F * -1 * Scale, 4.2F * Scale, 4.2F * Scale, 180F, 360F);
				Path.AddPolygon(new PointF[]
				{
					new PointF(-2.2F * Scale, -2.2F * -1 * Scale), 
					new PointF(-2.2F * Scale, 1.5F * -1 * Scale), 
					new PointF(-1.5F * Scale, 2.15F * -1 * Scale), 
					new PointF(1.5F * Scale, 2.15F * -1 * Scale), 
					new PointF(2.2F * Scale, 1.5F * -1 * Scale), 
					new PointF(2.2F * Scale, -2.2F * -1 * Scale), 
					new PointF(-2.1F * Scale, -2.2F * -1 * Scale)
				});
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("MU", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new MU(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.MU);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			Width = 6.6F;
			Height = 4.4F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int MUMiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.MUMiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.MUMiddleCenter);
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
				case ControlPointIds.MUMiddleCenter:
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
