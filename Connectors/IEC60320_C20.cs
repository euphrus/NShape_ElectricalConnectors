using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class IEC60320_C20 : RectangleFBase
	{

		#region Constructors

		protected internal IEC60320_C20(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			Width = 35.5F;
			Height = 27.5F;
		}

		protected internal IEC60320_C20(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			Width = 35.5F;
			Height = 27.5F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new IEC60320_C20(Type, Template);
			result.CopyFrom(this);
			return result;
		}

		protected override bool CalculatePath()
		{
			if (base.CalculatePath())
			{
				Path.Reset();
				Path.Reset();
				Path.AddRectangle(new RectangleF(-17.75F * Scale, 13.75F * -1 * Scale, 35.5F * Scale, 27.5F * Scale));
				Path.AddLines(new PointF[]{new PointF(-14.5F * Scale, 3.5F * -1 * Scale), new PointF(-6.721826F * Scale, 10.5F * -1 * Scale), new PointF(6.721826F * Scale, 10.5F * -1 * Scale), new PointF(14.5F * Scale, 3.5F * -1 * Scale)});
				Path.AddArc(11.5F * Scale, -7.5F * -1 * Scale, 3F * Scale, 3F * Scale, 360F, 90F);
				Path.AddArc(-14.5F * Scale, -7.5F * -1 * Scale, 3F * Scale, 3F * Scale, 90F, 90F);
				Path.CloseFigure();
				Path.AddRectangle(new RectangleF(-9F * Scale, -3F * -1 * Scale, 5F * Scale, 2F * Scale));
				Path.AddRectangle(new RectangleF(-8.15F * Scale, -3.5F * -1 * Scale, 3.3F * Scale, 1F * Scale));
				Path.AddRectangle(new RectangleF(-3F * Scale, 5F * -1 * Scale, 6F * Scale, 2F * Scale));
				Path.AddRectangle(new RectangleF(-2.15F * Scale, 4.5F * -1 * Scale, 4.3F * Scale, 1F * Scale));
				Path.AddRectangle(new RectangleF(4F * Scale, -3F * -1 * Scale, 5F * Scale, 2F * Scale));
				Path.AddRectangle(new RectangleF(4.85F * Scale, -3.5F * -1 * Scale, 3.3F * Scale, 1F * Scale));
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("IEC60320_C20", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new IEC60320_C20(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.IEC60320_C20);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			Width = 35.5F;
			Height = 27.5F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int IEC60320_C20MiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.IEC60320_C20MiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.IEC60320_C20MiddleCenter);
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
				case ControlPointIds.IEC60320_C20MiddleCenter:
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
