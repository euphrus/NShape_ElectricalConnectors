using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class SC : RectangleFBase
	{

		#region Constructors

		protected internal SC(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			Width = 8.79F;
			Height = 7.99F;
		}

		protected internal SC(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			Width = 8.79F;
			Height = 7.99F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new SC(Type, Template);
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
					new PointF(-2.7F * Scale, -3.1F * -1 * Scale), 
					new PointF(-2.7F * Scale, 1.7F * -1 * Scale), 
					new PointF(-2.1F * Scale, 2.3F * -1 * Scale), 
					new PointF(2.1F * Scale, 2.3F * -1 * Scale), 
					new PointF(2.7F * Scale, 1.7F * -1 * Scale), 
					new PointF(2.7F * Scale, -3.1F * -1 * Scale), 
					new PointF(-2.7F * Scale, -3.1F * -1 * Scale)
				});
				Path.AddRectangle(new RectangleF(-4.395F * Scale, 3.195F * -1 * Scale, 8.79F * Scale, 7.19F * Scale));
				Path.AddRectangle(new RectangleF(-0.8F * Scale, 3.995F * -1 * Scale, 1.6F * Scale, 0.8F * Scale));
				Path.AddRectangle(new RectangleF(-4.395F * Scale, 1.195F * -1 * Scale, 0.995F * Scale, 3.2F * Scale));
				Path.AddRectangle(new RectangleF(3.4F * Scale, 1.195F * -1 * Scale, 0.995F * Scale, 3.2F * Scale));
				Path.AddRectangle(new RectangleF(3.4F * Scale, 0.3499999F * -1 * Scale, 0.095F * Scale, 1.5F * Scale));
				Path.AddRectangle(new RectangleF(-3.52F * Scale, 0.3499999F * -1 * Scale, 0.12F * Scale, 1.5F * Scale));
				Path.AddRectangle(new RectangleF(3.6F * Scale, 3.2F * -1 * Scale, 0.8F * Scale, 2F * Scale));
				Path.AddRectangle(new RectangleF(3.6F * Scale, 3.2F * -1 * Scale, 0.8F * Scale, 2F * Scale));
				Path.AddRectangle(new RectangleF(-4.4F * Scale, 3.2F * -1 * Scale, 0.8F * Scale, 2F * Scale));
				Path.AddRectangle(new RectangleF(-4.4F * Scale, 3.2F * -1 * Scale, 0.8F * Scale, 2F * Scale));
				Path.AddRectangle(new RectangleF(-4.4F * Scale, -2F * -1 * Scale, 0.8F * Scale, 2F * Scale));
				Path.AddRectangle(new RectangleF(-4.4F * Scale, -2F * -1 * Scale, 0.8F * Scale, 2F * Scale));
				Path.AddRectangle(new RectangleF(3.6F * Scale, -2F * -1 * Scale, 0.8F * Scale, 2F * Scale));
				Path.AddRectangle(new RectangleF(3.6F * Scale, -2F * -1 * Scale, 0.8F * Scale, 2F * Scale));
				Path.AddRectangle(new RectangleF(-4.4F * Scale, 1.2F * -1 * Scale, 0.995F * Scale, 0.7F * Scale));
				Path.AddRectangle(new RectangleF(3.4F * Scale, 1.2F * -1 * Scale, 0.995F * Scale, 0.7F * Scale));
				Path.AddRectangle(new RectangleF(-4.4F * Scale, -1.3F * -1 * Scale, 0.995F * Scale, 0.7F * Scale));
				Path.AddRectangle(new RectangleF(3.4F * Scale, -1.3F * -1 * Scale, 0.995F * Scale, 0.7F * Scale));
				Path.AddArc(-2.4F * Scale, 2F * -1 * Scale, 4.8F * Scale, 4.8F * Scale, 180F, 360F);
				Path.AddArc(-1.24925F * Scale, 0.84925F * -1 * Scale, 2.4985F * Scale, 2.4985F * Scale, 180F, 360F);
				Path.AddArc(-1F * Scale, 0.6F * -1 * Scale, 2F * Scale, 2F * Scale, 180F, 360F);
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("SC", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new SC(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.SC);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			Width = 8.79F;
			Height = 7.99F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int SCMiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.SCMiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.SCMiddleCenter);
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
				case ControlPointIds.SCMiddleCenter:
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
