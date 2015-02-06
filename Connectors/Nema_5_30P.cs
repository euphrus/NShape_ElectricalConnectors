using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class Nema_5_30P : RectangleFBase
	{

		#region Constructors

		protected internal Nema_5_30P(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			Width = 30F;
			Height = 30F;
		}

		protected internal Nema_5_30P(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			Width = 30F;
			Height = 30F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new Nema_5_30P(Type, Template);
			result.CopyFrom(this);
			return result;
		}

		protected override bool CalculatePath()
		{
			if (base.CalculatePath())
			{
				Path.Reset();
				Path.Reset();
				Path.AddArc(-15F * Scale * _pixelToMmMultiple, 15F * -1 * Scale * _pixelToMmMultiple, 30F * Scale * _pixelToMmMultiple, 30F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddRectangle(new RectangleF(5.588F * Scale * _pixelToMmMultiple, 0.005F * -1 * Scale * _pixelToMmMultiple, 1.524F * Scale * _pixelToMmMultiple, 6.604F * Scale * _pixelToMmMultiple));
				Path.AddArc(-2.413F * Scale * _pixelToMmMultiple, 8.7122F * -1 * Scale * _pixelToMmMultiple, 4.826F * Scale * _pixelToMmMultiple, 4.826F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-8.5F * Scale * _pixelToMmMultiple, -3F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 180F, 90F);
				Path.AddLines(new PointF[]{new PointF(-3.5F * Scale * _pixelToMmMultiple, -3F * -1 * Scale * _pixelToMmMultiple), new PointF(-3.5F * Scale * _pixelToMmMultiple, -4.2F * -1 * Scale * _pixelToMmMultiple)});
				Path.AddArc(-7.5F * Scale * _pixelToMmMultiple, -4.2F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 270F, -90F);
				Path.AddLines(new PointF[]{new PointF(-7.5F * Scale * _pixelToMmMultiple, -8F * -1 * Scale * _pixelToMmMultiple), new PointF(-8.5F * Scale * _pixelToMmMultiple, -8F * -1 * Scale * _pixelToMmMultiple)});
				Path.CloseFigure();
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("Nema_5_30P", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new Nema_5_30P(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.Nema_5_30P);
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
			public const int Nema_5_30PMiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.Nema_5_30PMiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.Nema_5_30PMiddleCenter);
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
				case ControlPointIds.Nema_5_30PMiddleCenter:
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
