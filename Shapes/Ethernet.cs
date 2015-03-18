using System.Collections.Generic;
using System.Drawing;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.NShape.Ports
{

	public class Ethernet : RectangleFBase
	{

		public enum MemberShape
		{
			Ethernet
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

		protected internal Ethernet(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			WidthF = 11.83F;
			HeightF = 9.36F;
		}

		protected internal Ethernet(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			WidthF = 11.83F;
			HeightF = 9.36F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new Ethernet(Type, Template);
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
					case MemberShape.Ethernet:
						EthernetPath();
						break;
				}
				return true;
			}
			return false;
		}

		private void EthernetPath()
		{
			WidthF = 11.83F;
			HeightF = 9.36F;
			Path.StartFigure();
			Path.AddArc(-5.915F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 90F, 90F);
			Path.AddLines(new PointF[]{new PointF(-5.915F * Scale * _pixelToMmMultiple, 0.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-3.05F * Scale * _pixelToMmMultiple, 0.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-3.05F * Scale * _pixelToMmMultiple, -0.14F * -1 * Scale * _pixelToMmMultiple), new PointF(3.05F * Scale * _pixelToMmMultiple, -0.14F * -1 * Scale * _pixelToMmMultiple), new PointF(3.05F * Scale * _pixelToMmMultiple, 0.68F * -1 * Scale * _pixelToMmMultiple), new PointF(5.915F * Scale * _pixelToMmMultiple, 0.68F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddArc(5.415F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 360F, 90F);
			Path.AddLines(new PointF[]{new PointF(3.75F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(3.75F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(3.25F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(3.25F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(2.75F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(2.75F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(2.25F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(2.25F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(1.75F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(1.75F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(1.25F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(1.25F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(0.75F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(0.75F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(0.25F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(0.25F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-0.25F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-0.25F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(-0.75F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(-0.75F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.25F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.25F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.75F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.75F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-2.25F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-2.25F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(-2.75F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(-2.75F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-3.25F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-3.25F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(-3.75F * Scale * _pixelToMmMultiple, -4.18F * -1 * Scale * _pixelToMmMultiple), new PointF(-3.75F * Scale * _pixelToMmMultiple, -4.68F * -1 * Scale * _pixelToMmMultiple)});
			Path.CloseFigure();
			Path.StartFigure();
			Path.AddArc(-5.915F * Scale * _pixelToMmMultiple, 1.925F * -1 * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 180F, 90F);
			Path.AddLines(new PointF[]{new PointF(-3.05F * Scale * _pixelToMmMultiple, 1.925F * -1 * Scale * _pixelToMmMultiple), new PointF(-3.05F * Scale * _pixelToMmMultiple, 0.68F * -1 * Scale * _pixelToMmMultiple), new PointF(-5.915F * Scale * _pixelToMmMultiple, 0.68F * -1 * Scale * _pixelToMmMultiple)});
			Path.CloseFigure();
			Path.StartFigure();
			Path.AddArc(5.415F * Scale * _pixelToMmMultiple, 1.925F * -1 * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 270F, 90F);
			Path.AddLines(new PointF[]{new PointF(5.915F * Scale * _pixelToMmMultiple, 0.68F * -1 * Scale * _pixelToMmMultiple), new PointF(3.05F * Scale * _pixelToMmMultiple, 0.68F * -1 * Scale * _pixelToMmMultiple), new PointF(3.05F * Scale * _pixelToMmMultiple, 1.925F * -1 * Scale * _pixelToMmMultiple)});
			Path.CloseFigure();
			Path.AddLines(new PointF[]{new PointF(-3.05F * Scale * _pixelToMmMultiple, -0.14F * -1 * Scale * _pixelToMmMultiple), new PointF(-3.05F * Scale * _pixelToMmMultiple, 2.91F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.625F * Scale * _pixelToMmMultiple, 2.91F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.625F * Scale * _pixelToMmMultiple, 2.34F * -1 * Scale * _pixelToMmMultiple), new PointF(1.625F * Scale * _pixelToMmMultiple, 2.34F * -1 * Scale * _pixelToMmMultiple), new PointF(1.625F * Scale * _pixelToMmMultiple, 2.91F * -1 * Scale * _pixelToMmMultiple), new PointF(3.05F * Scale * _pixelToMmMultiple, 2.91F * -1 * Scale * _pixelToMmMultiple), new PointF(3.05F * Scale * _pixelToMmMultiple, -0.14F * -1 * Scale * _pixelToMmMultiple)});
			Path.CloseFigure();
			Path.AddRectangle(new RectangleF(-1.625F * Scale * _pixelToMmMultiple, 4.68F * -1 * Scale * _pixelToMmMultiple, 3.25F * Scale * _pixelToMmMultiple, 2.34F * Scale * _pixelToMmMultiple));
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "Ports";
			return new ShapeType("Ethernet", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new Ethernet(s, t); },
			Ethernet.GetPropertyDefinitions, Windstream.NShape.Ports.Properties.Resources.Ethernet);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			WidthF = 11.83F;
			HeightF = 9.36F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int EthernetMiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.EthernetMiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.EthernetMiddleCenter);
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
				case ControlPointIds.EthernetMiddleCenter:
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