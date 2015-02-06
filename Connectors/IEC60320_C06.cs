using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class IEC60320_C06 : RectangleFBase
	{

		#region Constructors

		protected internal IEC60320_C06(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			Width = 22.5F;
			Height = 17.5F;
		}

		protected internal IEC60320_C06(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			Width = 22.5F;
			Height = 17.5F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new IEC60320_C06(Type, Template);
			result.CopyFrom(this);
			return result;
		}

		protected override bool CalculatePath()
		{
			if (base.CalculatePath())
			{
				Path.Reset();
				Path.Reset();
				Path.AddArc(-11.25F * Scale * _pixelToMmMultiple, 8.75F * -1 * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 180F, 90F);
				Path.AddArc(8.25F * Scale * _pixelToMmMultiple, 8.75F * -1 * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 270F, 90F);
				Path.AddArc(8.25F * Scale * _pixelToMmMultiple, -5.75F * -1 * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 360F, 90F);
				Path.AddArc(-11.25F * Scale * _pixelToMmMultiple, -5.75F * -1 * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 90F, 90F);
				Path.CloseFigure();
				Path.AddArc(-1.6F * Scale * _pixelToMmMultiple, 4.2F * -1 * Scale * _pixelToMmMultiple, 3.2F * Scale * _pixelToMmMultiple, 3.2F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-6.15F * Scale * _pixelToMmMultiple, -0.85F * -1 * Scale * _pixelToMmMultiple, 2.36F * Scale * _pixelToMmMultiple, 2.36F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(3.85F * Scale * _pixelToMmMultiple, -0.85F * -1 * Scale * _pixelToMmMultiple, 2.36F * Scale * _pixelToMmMultiple, 2.36F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-4.5F * Scale * _pixelToMmMultiple, 7F * -1 * Scale * _pixelToMmMultiple, 9F * Scale * _pixelToMmMultiple, 9F * Scale * _pixelToMmMultiple, 175F, 190F);
				Path.AddArc(0.9F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple, 8.2F * Scale * _pixelToMmMultiple, 8.2F * Scale * _pixelToMmMultiple, 263F, 277F);
				Path.AddArc(-9.1F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple, 8.2F * Scale * _pixelToMmMultiple, 8.2F * Scale * _pixelToMmMultiple, 360F, 277F);
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("IEC60320_C06", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new IEC60320_C06(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.IEC60320_C06);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			Width = 22.5F;
			Height = 17.5F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int IEC60320_C06MiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.IEC60320_C06MiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.IEC60320_C06MiddleCenter);
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
				case ControlPointIds.IEC60320_C06MiddleCenter:
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
