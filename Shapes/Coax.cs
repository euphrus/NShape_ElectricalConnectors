using System.Collections.Generic;
using System.Drawing;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.NShape.Ports
{

	public class Coax : RectangleFBase
	{

		public enum MemberShape
		{
			BNC,
			FourP4C,
			MiniBNC,
			RF_N_Plug,
			RF_SMA_Plug,
			RF_TNC_Plug
		}

		private MemberShape _member;
		public MemberShape Member
		{
			get
			{
				return _member;
			}
			set
			{
				if (_member != value)
				{
					_member = value;
					Invalidate();
					InvalidateDrawCache();
				}
			}
		}

		#region Constructors

		protected internal Coax(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			WidthF = 11.91F;
			HeightF = 9.91F;
		}

		protected internal Coax(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			WidthF = 11.91F;
			HeightF = 9.91F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new Coax(Type, Template);
			result.CopyFrom(this);
			return result;
		}

		protected override bool CalculatePath()
		{
			if (base.CalculatePath())
			{
				Path.Reset();
				switch (Member)
				{
					case MemberShape.BNC:
						BNCPath();
						break;
					case MemberShape.FourP4C:
						FourP4CPath();
						break;
					case MemberShape.MiniBNC:
						MiniBNCPath();
						break;
					case MemberShape.RF_N_Plug:
						RF_N_PlugPath();
						break;
					case MemberShape.RF_SMA_Plug:
						RF_SMA_PlugPath();
						break;
					case MemberShape.RF_TNC_Plug:
						RF_TNC_PlugPath();
						break;
				}
				return true;
			}
			return false;
		}

		private void BNCPath()
		{
			WidthF = 11.91F;
			HeightF = 9.91F;
			Path.AddPolygon(new PointF[]
			{
					new PointF(-4.905F * Scale * _pixelToMmMultiple, -4.905F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-4.905F * Scale * _pixelToMmMultiple, -0.5F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-5.905F * Scale * _pixelToMmMultiple, -0.5F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-5.905F * Scale * _pixelToMmMultiple, 0.5F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-4.905F * Scale * _pixelToMmMultiple, 0.5F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-4.905F * Scale * _pixelToMmMultiple, 4.905F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(4.905F * Scale * _pixelToMmMultiple, 4.905F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(4.905F * Scale * _pixelToMmMultiple, 0.5F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(5.905F * Scale * _pixelToMmMultiple, 0.5F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(5.905F * Scale * _pixelToMmMultiple, -0.5F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(4.905F * Scale * _pixelToMmMultiple, -0.5F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(4.905F * Scale * _pixelToMmMultiple, -4.905F * -1 * Scale * _pixelToMmMultiple)
			});
			Path.AddArc(-4.905F * Scale * _pixelToMmMultiple, 4.905F * -1 * Scale * _pixelToMmMultiple, 9.81F * Scale * _pixelToMmMultiple, 9.81F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-4.905F * Scale * _pixelToMmMultiple, 4.905F * -1 * Scale * _pixelToMmMultiple, 9.81F * Scale * _pixelToMmMultiple, 9.81F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-4.05F * Scale * _pixelToMmMultiple, 4.05F * -1 * Scale * _pixelToMmMultiple, 8.1F * Scale * _pixelToMmMultiple, 8.1F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-4.05F * Scale * _pixelToMmMultiple, 4.05F * -1 * Scale * _pixelToMmMultiple, 8.1F * Scale * _pixelToMmMultiple, 8.1F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-2.415F * Scale * _pixelToMmMultiple, 2.415F * -1 * Scale * _pixelToMmMultiple, 4.83F * Scale * _pixelToMmMultiple, 4.83F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-2.415F * Scale * _pixelToMmMultiple, 2.415F * -1 * Scale * _pixelToMmMultiple, 4.83F * Scale * _pixelToMmMultiple, 4.83F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-0.66F * Scale * _pixelToMmMultiple, 0.66F * -1 * Scale * _pixelToMmMultiple, 1.32F * Scale * _pixelToMmMultiple, 1.32F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-0.66F * Scale * _pixelToMmMultiple, 0.66F * -1 * Scale * _pixelToMmMultiple, 1.32F * Scale * _pixelToMmMultiple, 1.32F * Scale * _pixelToMmMultiple, 180F, 360F);
		}

		private void FourP4CPath()
		{
			WidthF = 7.62F;
			HeightF = 9.37F;
			Path.StartFigure();
			Path.AddArc(-3.81F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 90F, 90F);
			Path.AddLines(new PointF[]{new PointF(-3.81F * Scale * _pixelToMmMultiple, 0.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-3.05F * Scale * _pixelToMmMultiple, 0.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-3.05F * Scale * _pixelToMmMultiple, -0.14F * -1 * Scale * _pixelToMmMultiple), new PointF(3.05F * Scale * _pixelToMmMultiple, -0.14F * -1 * Scale * _pixelToMmMultiple), new PointF(3.05F * Scale * _pixelToMmMultiple, 0.68F * -1 * Scale * _pixelToMmMultiple), new PointF(3.81F * Scale * _pixelToMmMultiple, 0.68F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddArc(3.31F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 360F, 90F);
			Path.AddLines(new PointF[]{new PointF(2.25F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(1.75F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(1.75F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(1.25F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(1.25F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(0.75F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(0.75F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(0.25F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(0.25F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-0.25F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-0.25F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(-0.75F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(-0.75F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.25F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.25F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.75F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.75F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-2.25F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple)});
			Path.CloseFigure();
			Path.StartFigure();
			Path.AddArc(-3.81F * Scale * _pixelToMmMultiple, 1.925F * -1 * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 180F, 90F);
			Path.AddLines(new PointF[]{new PointF(-3.05F * Scale * _pixelToMmMultiple, 1.925F * -1 * Scale * _pixelToMmMultiple), new PointF(-3.05F * Scale * _pixelToMmMultiple, 0.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-3.81F * Scale * _pixelToMmMultiple, 0.68F * -1 * Scale * _pixelToMmMultiple)});
			Path.CloseFigure();
			Path.StartFigure();
			Path.AddArc(3.31F * Scale * _pixelToMmMultiple, 1.925F * -1 * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 270F, 90F);
			Path.AddLines(new PointF[]{new PointF(3.81F * Scale * _pixelToMmMultiple, 0.68F * -1 * Scale * _pixelToMmMultiple), new PointF(3.05F * Scale * _pixelToMmMultiple, 0.68F * -1 * Scale * _pixelToMmMultiple), new PointF(3.05F * Scale * _pixelToMmMultiple, 1.925F * -1 * Scale * _pixelToMmMultiple)});
			Path.CloseFigure();
			Path.AddLines(new PointF[]{new PointF(-3.05F * Scale * _pixelToMmMultiple, -0.14F * -1 * Scale * _pixelToMmMultiple), new PointF(-3.05F * Scale * _pixelToMmMultiple, 2.91F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.625F * Scale * _pixelToMmMultiple, 2.91F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.625F * Scale * _pixelToMmMultiple, 2.34F * -1 * Scale * _pixelToMmMultiple), new PointF(1.625F * Scale * _pixelToMmMultiple, 2.34F * -1 * Scale * _pixelToMmMultiple), new PointF(1.625F * Scale * _pixelToMmMultiple, 2.91F * -1 * Scale * _pixelToMmMultiple), new PointF(3.05F * Scale * _pixelToMmMultiple, 2.91F * -1 * Scale * _pixelToMmMultiple), new PointF(3.05F * Scale * _pixelToMmMultiple, -0.14F * -1 * Scale * _pixelToMmMultiple)});
			Path.CloseFigure();
			Path.AddRectangle(new RectangleF(-1.625F * Scale * _pixelToMmMultiple, 4.68F * -1 * Scale * _pixelToMmMultiple, 3.25F * Scale * _pixelToMmMultiple, 2.34F * Scale * _pixelToMmMultiple));
		}

		private void MiniBNCPath()
		{
			WidthF = 8.54F;
			HeightF = 7.54F;
			Path.AddPolygon(new PointF[]
			{
					new PointF(-3.77F * Scale * _pixelToMmMultiple, -3.77F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-3.77F * Scale * _pixelToMmMultiple, -0.5F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-4.27F * Scale * _pixelToMmMultiple, -0.5F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-4.27F * Scale * _pixelToMmMultiple, 0.5F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-3.77F * Scale * _pixelToMmMultiple, 0.5F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-3.77F * Scale * _pixelToMmMultiple, 3.77F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(3.77F * Scale * _pixelToMmMultiple, 3.77F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(3.77F * Scale * _pixelToMmMultiple, 0.5F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(4.27F * Scale * _pixelToMmMultiple, 0.5F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(4.27F * Scale * _pixelToMmMultiple, -0.5F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(3.77F * Scale * _pixelToMmMultiple, -0.5F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(3.77F * Scale * _pixelToMmMultiple, -3.77F * -1 * Scale * _pixelToMmMultiple)
			});
			Path.AddArc(-3.745F * Scale * _pixelToMmMultiple, 3.745F * -1 * Scale * _pixelToMmMultiple, 7.49F * Scale * _pixelToMmMultiple, 7.49F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-0.5F * Scale * _pixelToMmMultiple, 0.5F * -1 * Scale * _pixelToMmMultiple, 1F * Scale * _pixelToMmMultiple, 1F * Scale * _pixelToMmMultiple, 180F, 360F);
		}

		private void RF_N_PlugPath()
		{
			WidthF = 17F;
			HeightF = 17F;
			Path.AddArc(-8.5F * Scale * _pixelToMmMultiple, 8.5F * -1 * Scale * _pixelToMmMultiple, 17F * Scale * _pixelToMmMultiple, 17F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-8F * Scale * _pixelToMmMultiple, 8F * -1 * Scale * _pixelToMmMultiple, 16F * Scale * _pixelToMmMultiple, 16F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-8F * Scale * _pixelToMmMultiple, 8F * -1 * Scale * _pixelToMmMultiple, 16F * Scale * _pixelToMmMultiple, 16F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-4.69F * Scale * _pixelToMmMultiple, 4.69F * -1 * Scale * _pixelToMmMultiple, 9.38F * Scale * _pixelToMmMultiple, 9.38F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-4.19F * Scale * _pixelToMmMultiple, 4.19F * -1 * Scale * _pixelToMmMultiple, 8.38F * Scale * _pixelToMmMultiple, 8.38F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-4.19F * Scale * _pixelToMmMultiple, 4.19F * -1 * Scale * _pixelToMmMultiple, 8.38F * Scale * _pixelToMmMultiple, 8.38F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-0.8F * Scale * _pixelToMmMultiple, 0.8F * -1 * Scale * _pixelToMmMultiple, 1.6F * Scale * _pixelToMmMultiple, 1.6F * Scale * _pixelToMmMultiple, 180F, 360F);
		}

		private void RF_SMA_PlugPath()
		{
			WidthF = 8F;
			HeightF = 7F;
			Path.AddPolygon(new PointF[]
			{
					new PointF(4F * Scale * _pixelToMmMultiple, 0F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(2F * Scale * _pixelToMmMultiple, 3.464102F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-2F * Scale * _pixelToMmMultiple, 3.464102F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-4F * Scale * _pixelToMmMultiple, 4.90059E-16F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-2F * Scale * _pixelToMmMultiple, -3.464102F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(2F * Scale * _pixelToMmMultiple, -3.464102F * -1 * Scale * _pixelToMmMultiple)
			});
			Path.AddArc(-3.5F * Scale * _pixelToMmMultiple, 3.5F * -1 * Scale * _pixelToMmMultiple, 7F * Scale * _pixelToMmMultiple, 7F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-3.265F * Scale * _pixelToMmMultiple, 3.265F * -1 * Scale * _pixelToMmMultiple, 6.53F * Scale * _pixelToMmMultiple, 6.53F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-3.265F * Scale * _pixelToMmMultiple, 3.265F * -1 * Scale * _pixelToMmMultiple, 6.53F * Scale * _pixelToMmMultiple, 6.53F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-0.0255F * Scale * _pixelToMmMultiple, 0.0255F * -1 * Scale * _pixelToMmMultiple, 0.051F * Scale * _pixelToMmMultiple, 0.051F * Scale * _pixelToMmMultiple, 180F, 360F);
		}

		private void RF_TNC_PlugPath()
		{
			WidthF = 13F;
			HeightF = 13F;
			Path.AddArc(-6.5F * Scale * _pixelToMmMultiple, 6.5F * -1 * Scale * _pixelToMmMultiple, 13F * Scale * _pixelToMmMultiple, 13F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-5.59F * Scale * _pixelToMmMultiple, 5.59F * -1 * Scale * _pixelToMmMultiple, 11.18F * Scale * _pixelToMmMultiple, 11.18F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-5.59F * Scale * _pixelToMmMultiple, 5.59F * -1 * Scale * _pixelToMmMultiple, 11.18F * Scale * _pixelToMmMultiple, 11.18F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-4.03F * Scale * _pixelToMmMultiple, 4.03F * -1 * Scale * _pixelToMmMultiple, 8.06F * Scale * _pixelToMmMultiple, 8.06F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-4.03F * Scale * _pixelToMmMultiple, 4.03F * -1 * Scale * _pixelToMmMultiple, 8.06F * Scale * _pixelToMmMultiple, 8.06F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-4.03F * Scale * _pixelToMmMultiple, 4.03F * -1 * Scale * _pixelToMmMultiple, 8.06F * Scale * _pixelToMmMultiple, 8.06F * Scale * _pixelToMmMultiple, 180F, 0F);
			Path.AddArc(-2.415F * Scale * _pixelToMmMultiple, 2.415F * -1 * Scale * _pixelToMmMultiple, 4.93F * Scale * _pixelToMmMultiple, 4.93F * Scale * _pixelToMmMultiple, 180F, 0F);
			Path.AddArc(-2.415F * Scale * _pixelToMmMultiple, 2.415F * -1 * Scale * _pixelToMmMultiple, 4.83F * Scale * _pixelToMmMultiple, 4.83F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-0.66F * Scale * _pixelToMmMultiple, 0.66F * -1 * Scale * _pixelToMmMultiple, 1.32F * Scale * _pixelToMmMultiple, 1.32F * Scale * _pixelToMmMultiple, 180F, 360F);
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "Ports";
			return new ShapeType("Coax", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new Coax(s, t); },
			Coax.GetPropertyDefinitions, Windstream.NShape.Ports.Properties.Resources.Coax);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			WidthF = 11.91F;
			HeightF = 9.91F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int CoaxMiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.CoaxMiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.CoaxMiddleCenter);
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
				case ControlPointIds.CoaxMiddleCenter:
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

		new public static IEnumerable<EntityPropertyDefinition> GetPropertyDefinitions(int version)
		{
			foreach (EntityPropertyDefinition pi in RectangleFBase.GetPropertyDefinitions(version))
			{
				yield return pi;
			}
		}

		protected override void LoadFieldsCore(IRepositoryReader reader, int version)
		{
			base.LoadFieldsCore(reader, version);
		}

		protected override void SaveFieldsCore(IRepositoryWriter writer, int version)
		{
			base.SaveFieldsCore(writer, version);
		}

	}
}