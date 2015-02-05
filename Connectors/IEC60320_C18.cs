using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class IEC60320_C18 : RectangleFBase
	{

		#region Constructors

		protected internal IEC60320_C18(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			Width = 30.5F;
			Height = 22.5F;
		}

		protected internal IEC60320_C18(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			Width = 30.5F;
			Height = 22.5F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new IEC60320_C18(Type, Template);
			result.CopyFrom(this);
			return result;
		}

		protected override bool CalculatePath()
		{
			if (base.CalculatePath())
			{
				Path.Reset();
				Path.Reset();
				Path.AddRectangle(new RectangleF(-15.25F * Scale, 11.25F * -1 * Scale, 30.5F * Scale, 22.5F * Scale));
				Path.AddLines(new PointF[]{new PointF(-12F * Scale, 3F * -1 * Scale), new PointF(-8.464466F * Scale, 8F * -1 * Scale), new PointF(8.464466F * Scale, 8F * -1 * Scale), new PointF(12F * Scale, 2.5F * -1 * Scale)});
				Path.AddArc(9F * Scale, -5F * -1 * Scale, 3F * Scale, 3F * Scale, 360F, 90F);
				Path.AddArc(-12F * Scale, -5F * -1 * Scale, 3F * Scale, 3F * Scale, 90F, 90F);
				Path.CloseFigure();
				Path.AddRectangle(new RectangleF(-8F * Scale, 0F * -1 * Scale, 2F * Scale, 4F * Scale));
				Path.AddRectangle(new RectangleF(-7.5F * Scale, -0.85F * -1 * Scale, 1F * Scale, 2.3F * Scale));
				Path.AddRectangle(new RectangleF(-1F * Scale, 4F * -1 * Scale, 2F * Scale, 4F * Scale));
				Path.AddRectangle(new RectangleF(-0.5F * Scale, 3.15F * -1 * Scale, 1F * Scale, 2.3F * Scale));
				Path.AddRectangle(new RectangleF(6F * Scale, 0F * -1 * Scale, 2F * Scale, 4F * Scale));
				Path.AddRectangle(new RectangleF(6.5F * Scale, -0.85F * -1 * Scale, 1F * Scale, 2.3F * Scale));
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("IEC60320_C18", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new IEC60320_C18(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.IEC60320_C18);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			Width = 30.5F;
			Height = 22.5F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int IEC60320_C18MiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.IEC60320_C18MiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.IEC60320_C18MiddleCenter);
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
				case ControlPointIds.IEC60320_C18MiddleCenter:
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
