using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class RF_SMA_Plug : RectangleFBase
	{

		#region Constructors

		protected internal RF_SMA_Plug(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			Width = 8F;
			Height = 7F;
		}

		protected internal RF_SMA_Plug(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			Width = 8F;
			Height = 7F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new RF_SMA_Plug(Type, Template);
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
					new PointF(4F * Scale, 0F * -1 * Scale), 
					new PointF(2F * Scale, 3.464102F * -1 * Scale), 
					new PointF(-2F * Scale, 3.464102F * -1 * Scale), 
					new PointF(-4F * Scale, 4.90059E-16F * -1 * Scale), 
					new PointF(-2F * Scale, -3.464102F * -1 * Scale), 
					new PointF(2F * Scale, -3.464102F * -1 * Scale)
				});
				Path.AddArc(-3.5F * Scale, 3.5F * -1 * Scale, 7F * Scale, 7F * Scale, 180F, 360F);
				Path.AddArc(-3.265F * Scale, 3.265F * -1 * Scale, 6.53F * Scale, 6.53F * Scale, 180F, 360F);
				Path.AddArc(-3.265F * Scale, 3.265F * -1 * Scale, 6.53F * Scale, 6.53F * Scale, 180F, 360F);
				Path.AddArc(-0.0255F * Scale, 0.0255F * -1 * Scale, 0.051F * Scale, 0.051F * Scale, 180F, 360F);
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("RF_SMA_Plug", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new RF_SMA_Plug(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.RF_SMA_Plug);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			Width = 8F;
			Height = 7F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int RF_SMA_PlugMiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.RF_SMA_PlugMiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.RF_SMA_PlugMiddleCenter);
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
				case ControlPointIds.RF_SMA_PlugMiddleCenter:
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
