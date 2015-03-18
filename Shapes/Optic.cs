using System.Collections.Generic;
using System.Drawing;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.NShape.Ports
{

	public class Optic : RectangleFBase
	{

		public enum MemberShape
		{
			FC,
			LC,
			MU,
			SC
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

		protected internal Optic(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			WidthF = 9.8F;
			HeightF = 9.8F;
		}

		protected internal Optic(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			WidthF = 9.8F;
			HeightF = 9.8F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new Optic(Type, Template);
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
					case MemberShape.FC:
						FCPath();
						break;
					case MemberShape.LC:
						LCPath();
						break;
					case MemberShape.MU:
						MUPath();
						break;
					case MemberShape.SC:
						SCPath();
						break;
				}
				return true;
			}
			return false;
		}

		private void FCPath()
		{
			WidthF = 9.8F;
			HeightF = 9.8F;
			Path.AddArc(-4.9F * Scale * _pixelToMmMultiple, 4.9F * -1 * Scale * _pixelToMmMultiple, 9.8F * Scale * _pixelToMmMultiple, 9.8F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-4.85F * Scale * _pixelToMmMultiple, 4.85F * -1 * Scale * _pixelToMmMultiple, 9.7F * Scale * _pixelToMmMultiple, 9.7F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-4.85F * Scale * _pixelToMmMultiple, 4.85F * -1 * Scale * _pixelToMmMultiple, 9.7F * Scale * _pixelToMmMultiple, 9.7F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-4.45F * Scale * _pixelToMmMultiple, 4.45F * -1 * Scale * _pixelToMmMultiple, 8.9F * Scale * _pixelToMmMultiple, 8.9F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-4.45F * Scale * _pixelToMmMultiple, 4.45F * -1 * Scale * _pixelToMmMultiple, 8.9F * Scale * _pixelToMmMultiple, 8.9F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-3F * Scale * _pixelToMmMultiple, 3F * -1 * Scale * _pixelToMmMultiple, 6F * Scale * _pixelToMmMultiple, 6F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-3F * Scale * _pixelToMmMultiple, 3F * -1 * Scale * _pixelToMmMultiple, 6F * Scale * _pixelToMmMultiple, 6F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-1.2495F * Scale * _pixelToMmMultiple, 1.2495F * -1 * Scale * _pixelToMmMultiple, 2.499F * Scale * _pixelToMmMultiple, 2.499F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-1.2495F * Scale * _pixelToMmMultiple, 1.2495F * -1 * Scale * _pixelToMmMultiple, 2.499F * Scale * _pixelToMmMultiple, 2.499F * Scale * _pixelToMmMultiple, 180F, 360F);
		}

		private void LCPath()
		{
			WidthF = 6.02F;
			HeightF = 6.02F;
			Path.StartFigure();
			Path.AddLines(new PointF[]{new PointF(-2.2F * Scale * _pixelToMmMultiple, -1.9F * -1 * Scale * _pixelToMmMultiple), new PointF(-2.2F * Scale * _pixelToMmMultiple, 1.9F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddBezier(-2.2F * Scale * _pixelToMmMultiple, 1.9F * -1 * Scale * _pixelToMmMultiple, -2.2F * Scale * _pixelToMmMultiple, 2.2F * -1 * Scale * _pixelToMmMultiple, -1.9F * Scale * _pixelToMmMultiple, 2.2F * -1 * Scale * _pixelToMmMultiple, -1.9F * Scale * _pixelToMmMultiple, 2.2F * -1 * Scale * _pixelToMmMultiple);
			Path.AddLines(new PointF[]{new PointF(-1.59F * Scale * _pixelToMmMultiple, 2.2F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.59F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple), new PointF(1.59F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple), new PointF(1.59F * Scale * _pixelToMmMultiple, 2.2F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddBezier(1.9F * Scale * _pixelToMmMultiple, 2.2F * -1 * Scale * _pixelToMmMultiple, 1.9F * Scale * _pixelToMmMultiple, 2.2F * -1 * Scale * _pixelToMmMultiple, 2.2F * Scale * _pixelToMmMultiple, 2.2F * -1 * Scale * _pixelToMmMultiple, 2.2F * Scale * _pixelToMmMultiple, 1.9F * -1 * Scale * _pixelToMmMultiple);
			Path.AddLines(new PointF[]{new PointF(2.2F * Scale * _pixelToMmMultiple, 1.9F * -1 * Scale * _pixelToMmMultiple), new PointF(2.2F * Scale * _pixelToMmMultiple, -1.9F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddBezier(2.2F * Scale * _pixelToMmMultiple, -1.9F * -1 * Scale * _pixelToMmMultiple, 2.2F * Scale * _pixelToMmMultiple, -1.9F * -1 * Scale * _pixelToMmMultiple, 2.2F * Scale * _pixelToMmMultiple, -2.2F * -1 * Scale * _pixelToMmMultiple, 1.9F * Scale * _pixelToMmMultiple, -2.2F * -1 * Scale * _pixelToMmMultiple);
			Path.AddLines(new PointF[]{new PointF(1.9F * Scale * _pixelToMmMultiple, -2.2F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.9F * Scale * _pixelToMmMultiple, -2.2F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddBezier(-1.9F * Scale * _pixelToMmMultiple, -2.2F * -1 * Scale * _pixelToMmMultiple, -1.9F * Scale * _pixelToMmMultiple, -2.2F * -1 * Scale * _pixelToMmMultiple, -2.2F * Scale * _pixelToMmMultiple, -2.2F * -1 * Scale * _pixelToMmMultiple, -2.2F * Scale * _pixelToMmMultiple, -1.9F * -1 * Scale * _pixelToMmMultiple);
			Path.CloseFigure();
			Path.StartFigure();
			Path.AddLines(new PointF[]{new PointF(-2.1F * Scale * _pixelToMmMultiple, -1.8F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddBezier(-2.1F * Scale * _pixelToMmMultiple, 1.8F * -1 * Scale * _pixelToMmMultiple, -2.1F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple, -1.8F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple, -1.8F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple);
			Path.AddLines(new PointF[]{new PointF(-1.8F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple), new PointF(1.8F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddBezier(1.8F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple, 2.1F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple, 2.1F * Scale * _pixelToMmMultiple, 1.8F * -1 * Scale * _pixelToMmMultiple, 2.1F * Scale * _pixelToMmMultiple, 1.8F * -1 * Scale * _pixelToMmMultiple);
			Path.AddLines(new PointF[]{new PointF(2.1F * Scale * _pixelToMmMultiple, 1.2F * -1 * Scale * _pixelToMmMultiple), new PointF(2.1F * Scale * _pixelToMmMultiple, -1.2F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddBezier(2.1F * Scale * _pixelToMmMultiple, -1.8F * -1 * Scale * _pixelToMmMultiple, 2.1F * Scale * _pixelToMmMultiple, -1.8F * -1 * Scale * _pixelToMmMultiple, 2.1F * Scale * _pixelToMmMultiple, -2.1F * -1 * Scale * _pixelToMmMultiple, 1.8F * Scale * _pixelToMmMultiple, -2.1F * -1 * Scale * _pixelToMmMultiple);
			Path.AddLines(new PointF[]{new PointF(1.8F * Scale * _pixelToMmMultiple, -2.1F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.8F * Scale * _pixelToMmMultiple, -2.1F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddBezier(-1.8F * Scale * _pixelToMmMultiple, -2.1F * -1 * Scale * _pixelToMmMultiple, -2.1F * Scale * _pixelToMmMultiple, -2.1F * -1 * Scale * _pixelToMmMultiple, -2.1F * Scale * _pixelToMmMultiple, -1.8F * -1 * Scale * _pixelToMmMultiple, -2.1F * Scale * _pixelToMmMultiple, -1.8F * -1 * Scale * _pixelToMmMultiple);
			Path.CloseFigure();
			Path.StartFigure();
			Path.AddRectangle(new RectangleF(-1.6F * Scale * _pixelToMmMultiple, 2.39F * -1 * Scale * _pixelToMmMultiple, 3.2F * Scale * _pixelToMmMultiple, 0.29F * Scale * _pixelToMmMultiple));
			Path.CloseFigure();
			Path.StartFigure();
			Path.AddRectangle(new RectangleF(-1.6F * Scale * _pixelToMmMultiple, 2.59F * -1 * Scale * _pixelToMmMultiple, 3.2F * Scale * _pixelToMmMultiple, 0.2F * Scale * _pixelToMmMultiple));
			Path.CloseFigure();
			Path.StartFigure();
			Path.AddArc(-0.625F * Scale * _pixelToMmMultiple, 0.625F * -1 * Scale * _pixelToMmMultiple, 1.25F * Scale * _pixelToMmMultiple, 1.25F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.CloseFigure();
			Path.StartFigure();
			Path.AddArc(-0.3F * Scale * _pixelToMmMultiple, 0.3F * -1 * Scale * _pixelToMmMultiple, 0.6F * Scale * _pixelToMmMultiple, 0.6F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.CloseFigure();
			Path.StartFigure();
			Path.AddArc(-1.5F * Scale * _pixelToMmMultiple, 1.5F * -1 * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.CloseFigure();
		}

		private void MUPath()
		{
			WidthF = 6.6F;
			HeightF = 4.4F;
			Path.AddPolygon(new PointF[]
			{
					new PointF(-3.3F * Scale * _pixelToMmMultiple, -2.2F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-3.3F * Scale * _pixelToMmMultiple, 1.75F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-2.3F * Scale * _pixelToMmMultiple, 1.75F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-1.8F * Scale * _pixelToMmMultiple, 2.2F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(1.8F * Scale * _pixelToMmMultiple, 2.2F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(2.3F * Scale * _pixelToMmMultiple, 1.75F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(3.3F * Scale * _pixelToMmMultiple, 1.75F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(3.3F * Scale * _pixelToMmMultiple, -2.2F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-2.7F * Scale * _pixelToMmMultiple, -2.2F * -1 * Scale * _pixelToMmMultiple)
			});
			Path.AddRectangle(new RectangleF(-3.3F * Scale * _pixelToMmMultiple, 0.8F * -1 * Scale * _pixelToMmMultiple, 0.8F * Scale * _pixelToMmMultiple, 1.6F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(2.5F * Scale * _pixelToMmMultiple, 0.8F * -1 * Scale * _pixelToMmMultiple, 0.8F * Scale * _pixelToMmMultiple, 1.6F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(2.5F * Scale * _pixelToMmMultiple, 0.75F * -1 * Scale * _pixelToMmMultiple, 0.095F * Scale * _pixelToMmMultiple, 1.5F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-2.6F * Scale * _pixelToMmMultiple, 0.75F * -1 * Scale * _pixelToMmMultiple, 0.095F * Scale * _pixelToMmMultiple, 1.5F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(2.7F * Scale * _pixelToMmMultiple, 1.75F * -1 * Scale * _pixelToMmMultiple, 0.6F * Scale * _pixelToMmMultiple, 0.45F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-3.3F * Scale * _pixelToMmMultiple, 1.75F * -1 * Scale * _pixelToMmMultiple, 0.6F * Scale * _pixelToMmMultiple, 0.45F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-3.3F * Scale * _pixelToMmMultiple, -1.3F * -1 * Scale * _pixelToMmMultiple, 0.6F * Scale * _pixelToMmMultiple, 0.9F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(2.7F * Scale * _pixelToMmMultiple, -1.3F * -1 * Scale * _pixelToMmMultiple, 0.6F * Scale * _pixelToMmMultiple, 0.9F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-3.3F * Scale * _pixelToMmMultiple, 1.3F * -1 * Scale * _pixelToMmMultiple, 0.8F * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(2.5F * Scale * _pixelToMmMultiple, 1.3F * -1 * Scale * _pixelToMmMultiple, 0.8F * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-3.3F * Scale * _pixelToMmMultiple, -0.8F * -1 * Scale * _pixelToMmMultiple, 0.8F * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(2.5F * Scale * _pixelToMmMultiple, -0.8F * -1 * Scale * _pixelToMmMultiple, 0.8F * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple));
			Path.AddArc(-0.625F * Scale * _pixelToMmMultiple, 0.625F * -1 * Scale * _pixelToMmMultiple, 1.25F * Scale * _pixelToMmMultiple, 1.25F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-0.3F * Scale * _pixelToMmMultiple, 0.3F * -1 * Scale * _pixelToMmMultiple, 0.6F * Scale * _pixelToMmMultiple, 0.6F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-2.1F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple, 4.2F * Scale * _pixelToMmMultiple, 4.2F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddPolygon(new PointF[]
			{
					new PointF(-2.2F * Scale * _pixelToMmMultiple, -2.2F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-2.2F * Scale * _pixelToMmMultiple, 1.5F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-1.5F * Scale * _pixelToMmMultiple, 2.15F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(1.5F * Scale * _pixelToMmMultiple, 2.15F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(2.2F * Scale * _pixelToMmMultiple, 1.5F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(2.2F * Scale * _pixelToMmMultiple, -2.2F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-2.1F * Scale * _pixelToMmMultiple, -2.2F * -1 * Scale * _pixelToMmMultiple)
			});
		}

		private void SCPath()
		{
			WidthF = 8.79F;
			HeightF = 7.99F;
			Path.AddPolygon(new PointF[]
			{
					new PointF(-2.7F * Scale * _pixelToMmMultiple, -3.1F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-2.7F * Scale * _pixelToMmMultiple, 1.7F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-2.1F * Scale * _pixelToMmMultiple, 2.3F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(2.1F * Scale * _pixelToMmMultiple, 2.3F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(2.7F * Scale * _pixelToMmMultiple, 1.7F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(2.7F * Scale * _pixelToMmMultiple, -3.1F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-2.7F * Scale * _pixelToMmMultiple, -3.1F * -1 * Scale * _pixelToMmMultiple)
			});
			Path.AddRectangle(new RectangleF(-4.395F * Scale * _pixelToMmMultiple, 3.195F * -1 * Scale * _pixelToMmMultiple, 8.79F * Scale * _pixelToMmMultiple, 7.19F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-0.8F * Scale * _pixelToMmMultiple, 3.995F * -1 * Scale * _pixelToMmMultiple, 1.6F * Scale * _pixelToMmMultiple, 0.8F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-4.395F * Scale * _pixelToMmMultiple, 1.195F * -1 * Scale * _pixelToMmMultiple, 0.995F * Scale * _pixelToMmMultiple, 3.2F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(3.4F * Scale * _pixelToMmMultiple, 1.195F * -1 * Scale * _pixelToMmMultiple, 0.995F * Scale * _pixelToMmMultiple, 3.2F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(3.4F * Scale * _pixelToMmMultiple, 0.3499999F * -1 * Scale * _pixelToMmMultiple, 0.095F * Scale * _pixelToMmMultiple, 1.5F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-3.52F * Scale * _pixelToMmMultiple, 0.3499999F * -1 * Scale * _pixelToMmMultiple, 0.12F * Scale * _pixelToMmMultiple, 1.5F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(3.6F * Scale * _pixelToMmMultiple, 3.2F * -1 * Scale * _pixelToMmMultiple, 0.8F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(3.6F * Scale * _pixelToMmMultiple, 3.2F * -1 * Scale * _pixelToMmMultiple, 0.8F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-4.4F * Scale * _pixelToMmMultiple, 3.2F * -1 * Scale * _pixelToMmMultiple, 0.8F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-4.4F * Scale * _pixelToMmMultiple, 3.2F * -1 * Scale * _pixelToMmMultiple, 0.8F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-4.4F * Scale * _pixelToMmMultiple, -2F * -1 * Scale * _pixelToMmMultiple, 0.8F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-4.4F * Scale * _pixelToMmMultiple, -2F * -1 * Scale * _pixelToMmMultiple, 0.8F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(3.6F * Scale * _pixelToMmMultiple, -2F * -1 * Scale * _pixelToMmMultiple, 0.8F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(3.6F * Scale * _pixelToMmMultiple, -2F * -1 * Scale * _pixelToMmMultiple, 0.8F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-4.4F * Scale * _pixelToMmMultiple, 1.2F * -1 * Scale * _pixelToMmMultiple, 0.995F * Scale * _pixelToMmMultiple, 0.7F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(3.4F * Scale * _pixelToMmMultiple, 1.2F * -1 * Scale * _pixelToMmMultiple, 0.995F * Scale * _pixelToMmMultiple, 0.7F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-4.4F * Scale * _pixelToMmMultiple, -1.3F * -1 * Scale * _pixelToMmMultiple, 0.995F * Scale * _pixelToMmMultiple, 0.7F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(3.4F * Scale * _pixelToMmMultiple, -1.3F * -1 * Scale * _pixelToMmMultiple, 0.995F * Scale * _pixelToMmMultiple, 0.7F * Scale * _pixelToMmMultiple));
			Path.AddArc(-2.4F * Scale * _pixelToMmMultiple, 2F * -1 * Scale * _pixelToMmMultiple, 4.8F * Scale * _pixelToMmMultiple, 4.8F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-1.24925F * Scale * _pixelToMmMultiple, 0.84925F * -1 * Scale * _pixelToMmMultiple, 2.4985F * Scale * _pixelToMmMultiple, 2.4985F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-1F * Scale * _pixelToMmMultiple, 0.6F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 180F, 360F);
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "Ports";
			return new ShapeType("Optic", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new Optic(s, t); },
			Optic.GetPropertyDefinitions, Windstream.NShape.Ports.Properties.Resources.Optic);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			WidthF = 9.8F;
			HeightF = 9.8F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int OpticMiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.OpticMiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.OpticMiddleCenter);
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
				case ControlPointIds.OpticMiddleCenter:
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