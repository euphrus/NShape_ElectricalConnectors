using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class RF_TNC_Plug : RectangleFBase
	{

		#region Constructors

		protected internal RF_TNC_Plug(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			Width = 13F;
			Height = 13F;
		}

		protected internal RF_TNC_Plug(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			Width = 13F;
			Height = 13F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new RF_TNC_Plug(Type, Template);
			result.CopyFrom(this);
			return result;
		}

		protected override bool CalculatePath()
		{
			if (base.CalculatePath())
			{
				Path.Reset();
				Path.Reset();
				Path.AddArc(-6.5F * Scale * _pixelToMmMultiple, 6.5F * -1 * Scale * _pixelToMmMultiple, 13F * Scale * _pixelToMmMultiple, 13F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-5.59F * Scale * _pixelToMmMultiple, 5.59F * -1 * Scale * _pixelToMmMultiple, 11.18F * Scale * _pixelToMmMultiple, 11.18F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-5.59F * Scale * _pixelToMmMultiple, 5.59F * -1 * Scale * _pixelToMmMultiple, 11.18F * Scale * _pixelToMmMultiple, 11.18F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-4.03F * Scale * _pixelToMmMultiple, 4.03F * -1 * Scale * _pixelToMmMultiple, 8.06F * Scale * _pixelToMmMultiple, 8.06F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-4.03F * Scale * _pixelToMmMultiple, 4.03F * -1 * Scale * _pixelToMmMultiple, 8.06F * Scale * _pixelToMmMultiple, 8.06F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-4.03F * Scale * _pixelToMmMultiple, 4.03F * -1 * Scale * _pixelToMmMultiple, 8.06F * Scale * _pixelToMmMultiple, 8.06F * Scale * _pixelToMmMultiple, 180F, 0F);
				Path.AddArc(-2.415F * Scale * _pixelToMmMultiple, 2.415F * -1 * Scale * _pixelToMmMultiple, 4.93F * Scale * _pixelToMmMultiple, 4.93F * Scale * _pixelToMmMultiple, 180F, 0F);
				Path.AddArc(-2.415F * Scale * _pixelToMmMultiple, 2.415F * -1 * Scale * _pixelToMmMultiple, 4.83F * Scale * _pixelToMmMultiple, 4.83F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-0.66F * Scale * _pixelToMmMultiple, 0.66F * -1 * Scale * _pixelToMmMultiple, 1.32F * Scale * _pixelToMmMultiple, 1.32F * Scale * _pixelToMmMultiple, 180F, 360F);
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("RF_TNC_Plug", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new RF_TNC_Plug(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.RF_TNC_Plug);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			Width = 13F;
			Height = 13F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int RF_TNC_PlugMiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.RF_TNC_PlugMiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.RF_TNC_PlugMiddleCenter);
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
				case ControlPointIds.RF_TNC_PlugMiddleCenter:
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
