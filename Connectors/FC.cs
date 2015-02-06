using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class FC : RectangleFBase
	{

		#region Constructors

		protected internal FC(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			Width = 9.8F;
			Height = 9.8F;
		}

		protected internal FC(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			Width = 9.8F;
			Height = 9.8F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new FC(Type, Template);
			result.CopyFrom(this);
			return result;
		}

		protected override bool CalculatePath()
		{
			if (base.CalculatePath())
			{
				Path.Reset();
				Path.Reset();
				Path.AddArc(-4.9F * Scale * _pixelToMmMultiple, 4.9F * -1 * Scale * _pixelToMmMultiple, 9.8F * Scale * _pixelToMmMultiple, 9.8F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-4.85F * Scale * _pixelToMmMultiple, 4.85F * -1 * Scale * _pixelToMmMultiple, 9.7F * Scale * _pixelToMmMultiple, 9.7F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-4.85F * Scale * _pixelToMmMultiple, 4.85F * -1 * Scale * _pixelToMmMultiple, 9.7F * Scale * _pixelToMmMultiple, 9.7F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-4.45F * Scale * _pixelToMmMultiple, 4.45F * -1 * Scale * _pixelToMmMultiple, 8.9F * Scale * _pixelToMmMultiple, 8.9F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-4.45F * Scale * _pixelToMmMultiple, 4.45F * -1 * Scale * _pixelToMmMultiple, 8.9F * Scale * _pixelToMmMultiple, 8.9F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-3F * Scale * _pixelToMmMultiple, 3F * -1 * Scale * _pixelToMmMultiple, 6F * Scale * _pixelToMmMultiple, 6F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-3F * Scale * _pixelToMmMultiple, 3F * -1 * Scale * _pixelToMmMultiple, 6F * Scale * _pixelToMmMultiple, 6F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-1.2495F * Scale * _pixelToMmMultiple, 1.2495F * -1 * Scale * _pixelToMmMultiple, 2.499F * Scale * _pixelToMmMultiple, 2.499F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-1.2495F * Scale * _pixelToMmMultiple, 1.2495F * -1 * Scale * _pixelToMmMultiple, 2.499F * Scale * _pixelToMmMultiple, 2.499F * Scale * _pixelToMmMultiple, 180F, 360F);
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("FC", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new FC(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.FC);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			Width = 9.8F;
			Height = 9.8F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int FCMiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.FCMiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.FCMiddleCenter);
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
				case ControlPointIds.FCMiddleCenter:
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
