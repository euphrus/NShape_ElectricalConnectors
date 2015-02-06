using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class IEC60320_C08 : RectangleFBase
	{

		#region Constructors

		protected internal IEC60320_C08(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			Width = 22F;
			Height = 15F;
		}

		protected internal IEC60320_C08(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			Width = 22F;
			Height = 15F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new IEC60320_C08(Type, Template);
			result.CopyFrom(this);
			return result;
		}

		protected override bool CalculatePath()
		{
			if (base.CalculatePath())
			{
				Path.Reset();
				Path.Reset();
				Path.AddArc(-11F * Scale * _pixelToMmMultiple, 7.5F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 180F, 90F);
				Path.AddArc(9F * Scale * _pixelToMmMultiple, 7.5F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 270F, 90F);
				Path.AddArc(9F * Scale * _pixelToMmMultiple, -5.5F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 360F, 90F);
				Path.AddArc(-11F * Scale * _pixelToMmMultiple, -5.5F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 90F, 90F);
				Path.CloseFigure();
				Path.AddArc(-4.3F * Scale * _pixelToMmMultiple, 1.18F * -1 * Scale * _pixelToMmMultiple, 2.36F * Scale * _pixelToMmMultiple, 2.36F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(1.94F * Scale * _pixelToMmMultiple, 1.18F * -1 * Scale * _pixelToMmMultiple, 2.36F * Scale * _pixelToMmMultiple, 2.36F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.StartFigure();
				Path.AddArc(-8F * Scale * _pixelToMmMultiple, 4F * -1 * Scale * _pixelToMmMultiple, 8F * Scale * _pixelToMmMultiple, 8F * Scale * _pixelToMmMultiple, 90F, 180F);
				Path.AddArc(-1F * Scale * _pixelToMmMultiple, 4F * -1 * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 270F, 90F);
				Path.AddArc(-0.5F * Scale * _pixelToMmMultiple, 4.25F * -1 * Scale * _pixelToMmMultiple, 1F * Scale * _pixelToMmMultiple, 1F * Scale * _pixelToMmMultiple, 170F, -170F);
				Path.AddArc(0.5F * Scale * _pixelToMmMultiple, 4F * -1 * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 180F, 90F);
				Path.AddArc(0F * Scale * _pixelToMmMultiple, 4F * -1 * Scale * _pixelToMmMultiple, 8F * Scale * _pixelToMmMultiple, 8F * Scale * _pixelToMmMultiple, 270F, 180F);
				Path.AddArc(0.5F * Scale * _pixelToMmMultiple, -3.5F * -1 * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 90F, 90F);
				Path.AddArc(-0.5F * Scale * _pixelToMmMultiple, -3.25F * -1 * Scale * _pixelToMmMultiple, 1F * Scale * _pixelToMmMultiple, 1F * Scale * _pixelToMmMultiple, 360F, -180F);
				Path.AddArc(-1F * Scale * _pixelToMmMultiple, -3.5F * -1 * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 360F, 90F);
				Path.CloseFigure();
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("IEC60320_C08", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new IEC60320_C08(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.IEC60320_C08);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			Width = 22F;
			Height = 15F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int IEC60320_C08MiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.IEC60320_C08MiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.IEC60320_C08MiddleCenter);
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
				case ControlPointIds.IEC60320_C08MiddleCenter:
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
