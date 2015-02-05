using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class Nema_1_20P : RectangleFBase
	{

		#region Constructors

		protected internal Nema_1_20P(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			Width = 30F;
			Height = 30F;
		}

		protected internal Nema_1_20P(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			Width = 30F;
			Height = 30F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new Nema_1_20P(Type, Template);
			result.CopyFrom(this);
			return result;
		}

		protected override bool CalculatePath()
		{
			if (base.CalculatePath())
			{
				Path.Reset();
				Path.Reset();
				Path.AddArc(-15F * Scale, 15F * -1 * Scale, 30F * Scale, 30F * Scale, 180F, 360F);
				Path.AddRectangle(new RectangleF(5.588F * Scale, 3.302F * -1 * Scale, 1.524F * Scale, 6.604F * Scale));
				Path.AddArc(-8.588F * Scale, 0.7955F * -1 * Scale, 3F * Scale, 3F * Scale, 270F, 90F);
				Path.AddLines(new PointF[]{new PointF(-5.588F * Scale, -3.302F * -1 * Scale), new PointF(-7.074001F * Scale, -3.302F * -1 * Scale)});
				Path.AddArc(-10.112F * Scale, -0.4F * -1 * Scale, 3F * Scale, 3F * Scale, 360F, -90F);
				Path.AddLines(new PointF[]{new PointF(-12.192F * Scale, -0.4F * -1 * Scale), new PointF(-12.192F * Scale, 0.8F * -1 * Scale)});
				Path.CloseFigure();
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("Nema_1_20P", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new Nema_1_20P(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.Nema_1_20P);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			Width = 30F;
			Height = 30F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int Nema_1_20PMiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.Nema_1_20PMiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.Nema_1_20PMiddleCenter);
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
				case ControlPointIds.Nema_1_20PMiddleCenter:
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
