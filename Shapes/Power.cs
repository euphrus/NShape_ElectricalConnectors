using System.Collections.Generic;
using System.Drawing;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.NShape.Ports
{

	public class Power : RectangleFBase
	{

		public enum MemberShape
		{
			Blade,
			IEC60320_C01,
			IEC60320_C02,
			IEC60320_C05,
			IEC60320_C06,
			IEC60320_C07,
			IEC60320_C08,
			IEC60320_C09,
			IEC60320_C10,
			IEC60320_C13,
			IEC60320_C14,
			IEC60320_C15,
			IEC60320_C16,
			IEC60320_C17,
			IEC60320_C18,
			IEC60320_C19,
			IEC60320_C20,
			IEC60320_C21,
			IEC60320_C22,
			IEC60320_C23,
			IEC60320_C24,
			Lug,
			Nema_1_15P,
			Nema_1_20P,
			Nema_5_15P,
			Nema_5_20P,
			Nema_5_30P,
			Nema_5_50P,
			Nema_6_50P,
			PowerSupplyVoltageSwitch,
			Ring
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

		protected internal Power(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			WidthF = 4.5F;
			HeightF = 19.5F;
		}

		protected internal Power(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			WidthF = 4.5F;
			HeightF = 19.5F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new Power(Type, Template);
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
					case MemberShape.Blade:
						BladePath();
						break;
					case MemberShape.IEC60320_C01:
						IEC60320_C01Path();
						break;
					case MemberShape.IEC60320_C02:
						IEC60320_C02Path();
						break;
					case MemberShape.IEC60320_C05:
						IEC60320_C05Path();
						break;
					case MemberShape.IEC60320_C06:
						IEC60320_C06Path();
						break;
					case MemberShape.IEC60320_C07:
						IEC60320_C07Path();
						break;
					case MemberShape.IEC60320_C08:
						IEC60320_C08Path();
						break;
					case MemberShape.IEC60320_C09:
						IEC60320_C09Path();
						break;
					case MemberShape.IEC60320_C10:
						IEC60320_C10Path();
						break;
					case MemberShape.IEC60320_C13:
						IEC60320_C13Path();
						break;
					case MemberShape.IEC60320_C14:
						IEC60320_C14Path();
						break;
					case MemberShape.IEC60320_C15:
						IEC60320_C15Path();
						break;
					case MemberShape.IEC60320_C16:
						IEC60320_C16Path();
						break;
					case MemberShape.IEC60320_C17:
						IEC60320_C17Path();
						break;
					case MemberShape.IEC60320_C18:
						IEC60320_C18Path();
						break;
					case MemberShape.IEC60320_C19:
						IEC60320_C19Path();
						break;
					case MemberShape.IEC60320_C20:
						IEC60320_C20Path();
						break;
					case MemberShape.IEC60320_C21:
						IEC60320_C21Path();
						break;
					case MemberShape.IEC60320_C22:
						IEC60320_C22Path();
						break;
					case MemberShape.IEC60320_C23:
						IEC60320_C23Path();
						break;
					case MemberShape.IEC60320_C24:
						IEC60320_C24Path();
						break;
					case MemberShape.Lug:
						LugPath();
						break;
					case MemberShape.Nema_1_15P:
						Nema_1_15PPath();
						break;
					case MemberShape.Nema_1_20P:
						Nema_1_20PPath();
						break;
					case MemberShape.Nema_5_15P:
						Nema_5_15PPath();
						break;
					case MemberShape.Nema_5_20P:
						Nema_5_20PPath();
						break;
					case MemberShape.Nema_5_30P:
						Nema_5_30PPath();
						break;
					case MemberShape.Nema_5_50P:
						Nema_5_50PPath();
						break;
					case MemberShape.Nema_6_50P:
						Nema_6_50PPath();
						break;
					case MemberShape.PowerSupplyVoltageSwitch:
						PowerSupplyVoltageSwitchPath();
						break;
					case MemberShape.Ring:
						RingPath();
						break;
				}
				return true;
			}
			return false;
		}

		private void BladePath()
		{
			WidthF = 4.5F;
			HeightF = 19.5F;
			Path.StartFigure();
			Path.AddLines(new PointF[]{new PointF(2F * Scale * _pixelToMmMultiple, -9.75F * -1 * Scale * _pixelToMmMultiple), new PointF(-2.25F * Scale * _pixelToMmMultiple, -9.75F * -1 * Scale * _pixelToMmMultiple), new PointF(-2.25F * Scale * _pixelToMmMultiple, -4.75F * -1 * Scale * _pixelToMmMultiple), new PointF(-0.85F * Scale * _pixelToMmMultiple, -3.75F * -1 * Scale * _pixelToMmMultiple), new PointF(-0.85F * Scale * _pixelToMmMultiple, 1.25F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddArc(-1.4F * Scale * _pixelToMmMultiple, 5.25F * -1 * Scale * _pixelToMmMultiple, 2.8F * Scale * _pixelToMmMultiple, 4F * Scale * _pixelToMmMultiple, 100F, 80F);
			Path.AddLines(new PointF[]{new PointF(-1.4F * Scale * _pixelToMmMultiple, 3.25F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.4F * Scale * _pixelToMmMultiple, 9.75F * -1 * Scale * _pixelToMmMultiple), new PointF(1.4F * Scale * _pixelToMmMultiple, 9.75F * -1 * Scale * _pixelToMmMultiple), new PointF(1.4F * Scale * _pixelToMmMultiple, 3.25F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddArc(-1.4F * Scale * _pixelToMmMultiple, 5.25F * -1 * Scale * _pixelToMmMultiple, 2.8F * Scale * _pixelToMmMultiple, 4F * Scale * _pixelToMmMultiple, 360F, 80F);
			Path.AddLines(new PointF[]{new PointF(0.85F * Scale * _pixelToMmMultiple, 1.25F * -1 * Scale * _pixelToMmMultiple), new PointF(0.85F * Scale * _pixelToMmMultiple, -3.75F * -1 * Scale * _pixelToMmMultiple), new PointF(2.25F * Scale * _pixelToMmMultiple, -4.75F * -1 * Scale * _pixelToMmMultiple), new PointF(2.25F * Scale * _pixelToMmMultiple, -9.75F * -1 * Scale * _pixelToMmMultiple)});
			Path.CloseFigure();
		}

		private void IEC60320_C01Path()
		{
			WidthF = 18.5F;
			HeightF = 13F;
			Path.AddRectangle(new RectangleF(-9.25F * Scale * _pixelToMmMultiple, 6.5F * -1 * Scale * _pixelToMmMultiple, 18.5F * Scale * _pixelToMmMultiple, 13F * Scale * _pixelToMmMultiple));
			Path.StartFigure();
			Path.AddArc(-7.2F * Scale * _pixelToMmMultiple, 4F * -1 * Scale * _pixelToMmMultiple, 8F * Scale * _pixelToMmMultiple, 8F * Scale * _pixelToMmMultiple, 90F, 180F);
			Path.AddArc(-0.8F * Scale * _pixelToMmMultiple, 4F * -1 * Scale * _pixelToMmMultiple, 8F * Scale * _pixelToMmMultiple, 8F * Scale * _pixelToMmMultiple, 270F, 180F);
			Path.CloseFigure();
			Path.StartFigure();
			Path.AddArc(-7.2F * Scale * _pixelToMmMultiple, 4F * -1 * Scale * _pixelToMmMultiple, 8F * Scale * _pixelToMmMultiple, 8F * Scale * _pixelToMmMultiple, 90F, 180F);
			Path.AddArc(-0.8F * Scale * _pixelToMmMultiple, 4F * -1 * Scale * _pixelToMmMultiple, 8F * Scale * _pixelToMmMultiple, 8F * Scale * _pixelToMmMultiple, 270F, 180F);
			Path.StartFigure();
			Path.AddArc(-4.75F * Scale * _pixelToMmMultiple, 1.45F * -1 * Scale * _pixelToMmMultiple, 2.9F * Scale * _pixelToMmMultiple, 2.9F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.CloseFigure();
			Path.AddArc(-4.5F * Scale * _pixelToMmMultiple, 1.2F * -1 * Scale * _pixelToMmMultiple, 2.4F * Scale * _pixelToMmMultiple, 2.4F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.StartFigure();
			Path.AddArc(1.85F * Scale * _pixelToMmMultiple, 1.45F * -1 * Scale * _pixelToMmMultiple, 2.9F * Scale * _pixelToMmMultiple, 2.9F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.CloseFigure();
			Path.AddArc(2.1F * Scale * _pixelToMmMultiple, 1.2F * -1 * Scale * _pixelToMmMultiple, 2.4F * Scale * _pixelToMmMultiple, 2.4F * Scale * _pixelToMmMultiple, 180F, 360F);
		}

		private void IEC60320_C02Path()
		{
			WidthF = 19F;
			HeightF = 13.5F;
			Path.AddRectangle(new RectangleF(-9.5F * Scale * _pixelToMmMultiple, 6.75F * -1 * Scale * _pixelToMmMultiple, 19F * Scale * _pixelToMmMultiple, 13.5F * Scale * _pixelToMmMultiple));
			Path.StartFigure();
			Path.AddArc(-7.2F * Scale * _pixelToMmMultiple, 4.2F * -1 * Scale * _pixelToMmMultiple, 8.4F * Scale * _pixelToMmMultiple, 8.4F * Scale * _pixelToMmMultiple, 90F, 180F);
			Path.AddArc(-1.2F * Scale * _pixelToMmMultiple, 4.2F * -1 * Scale * _pixelToMmMultiple, 8.4F * Scale * _pixelToMmMultiple, 8.4F * Scale * _pixelToMmMultiple, 270F, 180F);
			Path.CloseFigure();
			Path.StartFigure();
			Path.AddArc(-7.2F * Scale * _pixelToMmMultiple, 4.2F * -1 * Scale * _pixelToMmMultiple, 8.4F * Scale * _pixelToMmMultiple, 8.4F * Scale * _pixelToMmMultiple, 90F, 180F);
			Path.AddArc(-1.2F * Scale * _pixelToMmMultiple, 4.2F * -1 * Scale * _pixelToMmMultiple, 8.4F * Scale * _pixelToMmMultiple, 8.4F * Scale * _pixelToMmMultiple, 270F, 180F);
			Path.StartFigure();
			Path.AddArc(-4.55F * Scale * _pixelToMmMultiple, 1.25F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.StartFigure();
			Path.AddArc(2.05F * Scale * _pixelToMmMultiple, 1.25F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 180F, 360F);
		}

		private void IEC60320_C05Path()
		{
			WidthF = 22F;
			HeightF = 17F;
			Path.AddArc(-11F * Scale * _pixelToMmMultiple, 8.5F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 180F, 90F);
			Path.AddArc(8.5F * Scale * _pixelToMmMultiple, 8.5F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 270F, 90F);
			Path.AddArc(8.5F * Scale * _pixelToMmMultiple, -6F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 360F, 90F);
			Path.AddArc(-11F * Scale * _pixelToMmMultiple, -6F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 90F, 90F);
			Path.CloseFigure();
			Path.AddArc(-1.9F * Scale * _pixelToMmMultiple, 4.4F * -1 * Scale * _pixelToMmMultiple, 3.8F * Scale * _pixelToMmMultiple, 3.8F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-1.65F * Scale * _pixelToMmMultiple, 4.15F * -1 * Scale * _pixelToMmMultiple, 3.3F * Scale * _pixelToMmMultiple, 3.3F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-6.45F * Scale * _pixelToMmMultiple, -0.55F * -1 * Scale * _pixelToMmMultiple, 2.9F * Scale * _pixelToMmMultiple, 2.9F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-6.2F * Scale * _pixelToMmMultiple, -0.8F * -1 * Scale * _pixelToMmMultiple, 2.4F * Scale * _pixelToMmMultiple, 2.4F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(3.55F * Scale * _pixelToMmMultiple, -0.55F * -1 * Scale * _pixelToMmMultiple, 2.9F * Scale * _pixelToMmMultiple, 2.9F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(3.8F * Scale * _pixelToMmMultiple, -0.8F * -1 * Scale * _pixelToMmMultiple, 2.4F * Scale * _pixelToMmMultiple, 2.4F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-4.5F * Scale * _pixelToMmMultiple, 7F * -1 * Scale * _pixelToMmMultiple, 9F * Scale * _pixelToMmMultiple, 9F * Scale * _pixelToMmMultiple, 175F, 190F);
			Path.AddArc(0.9F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple, 8.2F * Scale * _pixelToMmMultiple, 8.2F * Scale * _pixelToMmMultiple, 263F, 277F);
			Path.AddArc(-9.1F * Scale * _pixelToMmMultiple, 2.1F * -1 * Scale * _pixelToMmMultiple, 8.2F * Scale * _pixelToMmMultiple, 8.2F * Scale * _pixelToMmMultiple, 360F, 277F);
		}

		private void IEC60320_C06Path()
		{
			WidthF = 22.5F;
			HeightF = 17.5F;
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
		}

		private void IEC60320_C07Path()
		{
			WidthF = 21.5F;
			HeightF = 14.5F;
			Path.AddArc(-10.75F * Scale * _pixelToMmMultiple, 7.25F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 180F, 90F);
			Path.AddArc(8.75F * Scale * _pixelToMmMultiple, 7.25F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 270F, 90F);
			Path.AddArc(8.75F * Scale * _pixelToMmMultiple, -5.25F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 360F, 90F);
			Path.AddArc(-10.75F * Scale * _pixelToMmMultiple, -5.25F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 90F, 90F);
			Path.CloseFigure();
			Path.AddArc(-5F * Scale * _pixelToMmMultiple, 1.45F * -1 * Scale * _pixelToMmMultiple, 2.9F * Scale * _pixelToMmMultiple, 2.9F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-4.75F * Scale * _pixelToMmMultiple, 1.2F * -1 * Scale * _pixelToMmMultiple, 2.4F * Scale * _pixelToMmMultiple, 2.4F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(2.1F * Scale * _pixelToMmMultiple, 1.45F * -1 * Scale * _pixelToMmMultiple, 2.9F * Scale * _pixelToMmMultiple, 2.9F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(2.35F * Scale * _pixelToMmMultiple, 1.2F * -1 * Scale * _pixelToMmMultiple, 2.4F * Scale * _pixelToMmMultiple, 2.4F * Scale * _pixelToMmMultiple, 180F, 360F);
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
		}

		private void IEC60320_C08Path()
		{
			WidthF = 22F;
			HeightF = 15F;
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
		}

		private void IEC60320_C09Path()
		{
			WidthF = 25F;
			HeightF = 17F;
			Path.AddArc(-12.5F * Scale * _pixelToMmMultiple, 8.5F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 180F, 90F);
			Path.AddArc(10.5F * Scale * _pixelToMmMultiple, 8.5F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 270F, 90F);
			Path.AddArc(10.5F * Scale * _pixelToMmMultiple, -6.5F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 360F, 90F);
			Path.AddArc(-12.5F * Scale * _pixelToMmMultiple, -6.5F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 90F, 90F);
			Path.CloseFigure();
			Path.AddArc(-10F * Scale * _pixelToMmMultiple, 6F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 180F, 90F);
			Path.AddArc(8F * Scale * _pixelToMmMultiple, 6F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 270F, 90F);
			Path.AddArc(8F * Scale * _pixelToMmMultiple, -4F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 360F, 90F);
			Path.AddArc(-10F * Scale * _pixelToMmMultiple, -4F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 90F, 90F);
			Path.CloseFigure();
			Path.AddPolygon(new PointF[]
			{
					new PointF(-6.25F * Scale * _pixelToMmMultiple, -2.5F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-6.25F * Scale * _pixelToMmMultiple, 2.5F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-3.75F * Scale * _pixelToMmMultiple, 2.5F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-3.75F * Scale * _pixelToMmMultiple, -2.5F * -1 * Scale * _pixelToMmMultiple)
			});
			Path.AddPolygon(new PointF[]
			{
					new PointF(6.25F * Scale * _pixelToMmMultiple, -2.5F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(3.75F * Scale * _pixelToMmMultiple, -2.5F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(3.75F * Scale * _pixelToMmMultiple, 2.5F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(6.25F * Scale * _pixelToMmMultiple, 2.5F * -1 * Scale * _pixelToMmMultiple)
			});
		}

		private void IEC60320_C10Path()
		{
			WidthF = 25.5F;
			HeightF = 17.5F;
			Path.AddArc(-12.75F * Scale * _pixelToMmMultiple, 8.75F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 180F, 90F);
			Path.AddArc(10.25F * Scale * _pixelToMmMultiple, 8.75F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 270F, 90F);
			Path.AddArc(10.25F * Scale * _pixelToMmMultiple, -6.25F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 360F, 90F);
			Path.AddArc(-12.75F * Scale * _pixelToMmMultiple, -6.25F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 90F, 90F);
			Path.CloseFigure();
			Path.AddArc(-10.5F * Scale * _pixelToMmMultiple, 6.5F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 180F, 90F);
			Path.AddArc(8F * Scale * _pixelToMmMultiple, 6.5F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 270F, 90F);
			Path.AddArc(8F * Scale * _pixelToMmMultiple, -4F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 360F, 90F);
			Path.AddArc(-10.5F * Scale * _pixelToMmMultiple, -4F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 90F, 90F);
			Path.CloseFigure();
			Path.AddPolygon(new PointF[]
			{
					new PointF(-6F * Scale * _pixelToMmMultiple, -2F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-6F * Scale * _pixelToMmMultiple, 2F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-4F * Scale * _pixelToMmMultiple, 2F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-4F * Scale * _pixelToMmMultiple, -2F * -1 * Scale * _pixelToMmMultiple)
			});
			Path.AddPolygon(new PointF[]
			{
					new PointF(-5.5F * Scale * _pixelToMmMultiple, -1.65F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-5.5F * Scale * _pixelToMmMultiple, 1.65F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-4.5F * Scale * _pixelToMmMultiple, 1.65F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(-4.5F * Scale * _pixelToMmMultiple, -1.65F * -1 * Scale * _pixelToMmMultiple)
			});
			Path.AddPolygon(new PointF[]
			{
					new PointF(6F * Scale * _pixelToMmMultiple, -2F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(4F * Scale * _pixelToMmMultiple, -2F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(4F * Scale * _pixelToMmMultiple, 2F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(6F * Scale * _pixelToMmMultiple, 2F * -1 * Scale * _pixelToMmMultiple)
			});
			Path.AddPolygon(new PointF[]
			{
					new PointF(4.5F * Scale * _pixelToMmMultiple, -1.65F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(4.5F * Scale * _pixelToMmMultiple, 1.65F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(5.5F * Scale * _pixelToMmMultiple, 1.65F * -1 * Scale * _pixelToMmMultiple), 
					new PointF(5.5F * Scale * _pixelToMmMultiple, -1.65F * -1 * Scale * _pixelToMmMultiple)
			});
		}

		private void IEC60320_C13Path()
		{
			WidthF = 30F;
			HeightF = 22F;
			Path.AddRectangle(new RectangleF(-15F * Scale * _pixelToMmMultiple, 11F * -1 * Scale * _pixelToMmMultiple, 30F * Scale * _pixelToMmMultiple, 22F * Scale * _pixelToMmMultiple));
			Path.StartFigure();
			Path.AddArc(-11.5F * Scale * _pixelToMmMultiple, -4.4F * -1 * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 90F, 90F);
			Path.AddLines(new PointF[]{new PointF(-11.5F * Scale * _pixelToMmMultiple, 2.5F * -1 * Scale * _pixelToMmMultiple), new PointF(-4.75F * Scale * _pixelToMmMultiple, 7.9F * -1 * Scale * _pixelToMmMultiple), new PointF(4.75F * Scale * _pixelToMmMultiple, 7.9F * -1 * Scale * _pixelToMmMultiple), new PointF(11.5F * Scale * _pixelToMmMultiple, 2.5F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddArc(8F * Scale * _pixelToMmMultiple, -4.4F * -1 * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 360F, 90F);
			Path.CloseFigure();
			Path.AddRectangle(new RectangleF(-8.25F * Scale * _pixelToMmMultiple, 0.5F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 5F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(5.75F * Scale * _pixelToMmMultiple, 0.5F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 5F * Scale * _pixelToMmMultiple));
		}

		private void IEC60320_C14Path()
		{
			WidthF = 30.5F;
			HeightF = 22.5F;
			Path.AddRectangle(new RectangleF(-15.25F * Scale * _pixelToMmMultiple, 11.25F * -1 * Scale * _pixelToMmMultiple, 30.5F * Scale * _pixelToMmMultiple, 22.5F * Scale * _pixelToMmMultiple));
			Path.StartFigure();
			Path.AddArc(-12F * Scale * _pixelToMmMultiple, -5F * -1 * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 90F, 90F);
			Path.AddLines(new PointF[]{new PointF(-12F * Scale * _pixelToMmMultiple, 3F * -1 * Scale * _pixelToMmMultiple), new PointF(-5F * Scale * _pixelToMmMultiple, 8F * -1 * Scale * _pixelToMmMultiple), new PointF(5F * Scale * _pixelToMmMultiple, 8F * -1 * Scale * _pixelToMmMultiple), new PointF(12F * Scale * _pixelToMmMultiple, 3F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddArc(9F * Scale * _pixelToMmMultiple, -5F * -1 * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 360F, 90F);
			Path.CloseFigure();
			Path.AddRectangle(new RectangleF(-8F * Scale * _pixelToMmMultiple, 0F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 4F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-7.5F * Scale * _pixelToMmMultiple, -0.85F * -1 * Scale * _pixelToMmMultiple, 1F * Scale * _pixelToMmMultiple, 2.3F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(6F * Scale * _pixelToMmMultiple, 0F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 4F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(6.5F * Scale * _pixelToMmMultiple, -0.85F * -1 * Scale * _pixelToMmMultiple, 1F * Scale * _pixelToMmMultiple, 2.3F * Scale * _pixelToMmMultiple));
		}

		private void IEC60320_C15Path()
		{
			WidthF = 30F;
			HeightF = 22F;
			Path.AddRectangle(new RectangleF(-15F * Scale * _pixelToMmMultiple, 11F * -1 * Scale * _pixelToMmMultiple, 30F * Scale * _pixelToMmMultiple, 22F * Scale * _pixelToMmMultiple));
			Path.AddLines(new PointF[]{new PointF(-11.5F * Scale * _pixelToMmMultiple, 2.5F * -1 * Scale * _pixelToMmMultiple), new PointF(-6.727029F * Scale * _pixelToMmMultiple, 7.9F * -1 * Scale * _pixelToMmMultiple), new PointF(6.727029F * Scale * _pixelToMmMultiple, 7.9F * -1 * Scale * _pixelToMmMultiple), new PointF(11.5F * Scale * _pixelToMmMultiple, 2.5F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddArc(8F * Scale * _pixelToMmMultiple, -4.4F * -1 * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 360F, 90F);
			Path.AddArc(2.5F * Scale * _pixelToMmMultiple, -6.65F * -1 * Scale * _pixelToMmMultiple, 1.25F * Scale * _pixelToMmMultiple, 1.25F * Scale * _pixelToMmMultiple, 90F, 90F);
			Path.AddArc(-2.5F * Scale * _pixelToMmMultiple, -2.5F * -1 * Scale * _pixelToMmMultiple, 5F * Scale * _pixelToMmMultiple, 5F * Scale * _pixelToMmMultiple, 360F, -180F);
			Path.AddArc(-3.75F * Scale * _pixelToMmMultiple, -6.65F * -1 * Scale * _pixelToMmMultiple, 1.25F * Scale * _pixelToMmMultiple, 1.25F * Scale * _pixelToMmMultiple, 360F, 90F);
			Path.AddArc(-11.5F * Scale * _pixelToMmMultiple, -4.4F * -1 * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 90F, 90F);
			Path.CloseFigure();
			Path.AddRectangle(new RectangleF(-8.25F * Scale * _pixelToMmMultiple, 0.5F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 5F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-1.25F * Scale * _pixelToMmMultiple, 4.5F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 5F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(5.75F * Scale * _pixelToMmMultiple, 0.5F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 5F * Scale * _pixelToMmMultiple));
		}

		private void IEC60320_C16Path()
		{
			WidthF = 30.5F;
			HeightF = 22.5F;
			Path.AddRectangle(new RectangleF(-15.25F * Scale * _pixelToMmMultiple, 11.25F * -1 * Scale * _pixelToMmMultiple, 30.5F * Scale * _pixelToMmMultiple, 22.5F * Scale * _pixelToMmMultiple));
			Path.AddLines(new PointF[]{new PointF(-12F * Scale * _pixelToMmMultiple, 3F * -1 * Scale * _pixelToMmMultiple), new PointF(-8.464466F * Scale * _pixelToMmMultiple, 8F * -1 * Scale * _pixelToMmMultiple), new PointF(8.464466F * Scale * _pixelToMmMultiple, 8F * -1 * Scale * _pixelToMmMultiple), new PointF(12F * Scale * _pixelToMmMultiple, 3F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddArc(9F * Scale * _pixelToMmMultiple, -4.9F * -1 * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 360F, 90F);
			Path.AddArc(2.5F * Scale * _pixelToMmMultiple, -6.65F * -1 * Scale * _pixelToMmMultiple, 1.25F * Scale * _pixelToMmMultiple, 1.25F * Scale * _pixelToMmMultiple, 90F, 90F);
			Path.AddArc(-2.5F * Scale * _pixelToMmMultiple, -2.5F * -1 * Scale * _pixelToMmMultiple, 5F * Scale * _pixelToMmMultiple, 5F * Scale * _pixelToMmMultiple, 360F, -180F);
			Path.AddArc(-3.75F * Scale * _pixelToMmMultiple, -6.65F * -1 * Scale * _pixelToMmMultiple, 1.25F * Scale * _pixelToMmMultiple, 1.25F * Scale * _pixelToMmMultiple, 360F, 90F);
			Path.AddArc(-12F * Scale * _pixelToMmMultiple, -4.9F * -1 * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 90F, 90F);
			Path.CloseFigure();
			Path.AddRectangle(new RectangleF(-8F * Scale * _pixelToMmMultiple, 0F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 4F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-7.5F * Scale * _pixelToMmMultiple, -0.85F * -1 * Scale * _pixelToMmMultiple, 1F * Scale * _pixelToMmMultiple, 2.3F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-1F * Scale * _pixelToMmMultiple, 4F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 4F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-0.5F * Scale * _pixelToMmMultiple, 3.15F * -1 * Scale * _pixelToMmMultiple, 1F * Scale * _pixelToMmMultiple, 2.3F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(6F * Scale * _pixelToMmMultiple, 0F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 4F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(6.5F * Scale * _pixelToMmMultiple, -0.85F * -1 * Scale * _pixelToMmMultiple, 1F * Scale * _pixelToMmMultiple, 2.3F * Scale * _pixelToMmMultiple));
		}

		private void IEC60320_C17Path()
		{
			WidthF = 30F;
			HeightF = 22F;
			Path.AddRectangle(new RectangleF(-15F * Scale * _pixelToMmMultiple, 11F * -1 * Scale * _pixelToMmMultiple, 30F * Scale * _pixelToMmMultiple, 22F * Scale * _pixelToMmMultiple));
			Path.AddLines(new PointF[]{new PointF(-11.5F * Scale * _pixelToMmMultiple, 2.5F * -1 * Scale * _pixelToMmMultiple), new PointF(-7.681623F * Scale * _pixelToMmMultiple, 8F * -1 * Scale * _pixelToMmMultiple), new PointF(7.681623F * Scale * _pixelToMmMultiple, 8F * -1 * Scale * _pixelToMmMultiple), new PointF(11.5F * Scale * _pixelToMmMultiple, 2.5F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddArc(8F * Scale * _pixelToMmMultiple, -4.5F * -1 * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 360F, 90F);
			Path.AddArc(-11.5F * Scale * _pixelToMmMultiple, -4.5F * -1 * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 90F, 90F);
			Path.CloseFigure();
			Path.AddRectangle(new RectangleF(-8.25F * Scale * _pixelToMmMultiple, 0.5F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 5F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-1.25F * Scale * _pixelToMmMultiple, 4.5F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 5F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(5.75F * Scale * _pixelToMmMultiple, 0.5F * -1 * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple, 5F * Scale * _pixelToMmMultiple));
		}

		private void IEC60320_C18Path()
		{
			WidthF = 30.5F;
			HeightF = 22.5F;
			Path.AddRectangle(new RectangleF(-15.25F * Scale * _pixelToMmMultiple, 11.25F * -1 * Scale * _pixelToMmMultiple, 30.5F * Scale * _pixelToMmMultiple, 22.5F * Scale * _pixelToMmMultiple));
			Path.AddLines(new PointF[]{new PointF(-12F * Scale * _pixelToMmMultiple, 3F * -1 * Scale * _pixelToMmMultiple), new PointF(-8.464466F * Scale * _pixelToMmMultiple, 8F * -1 * Scale * _pixelToMmMultiple), new PointF(8.464466F * Scale * _pixelToMmMultiple, 8F * -1 * Scale * _pixelToMmMultiple), new PointF(12F * Scale * _pixelToMmMultiple, 2.5F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddArc(9F * Scale * _pixelToMmMultiple, -5F * -1 * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 360F, 90F);
			Path.AddArc(-12F * Scale * _pixelToMmMultiple, -5F * -1 * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 90F, 90F);
			Path.CloseFigure();
			Path.AddRectangle(new RectangleF(-8F * Scale * _pixelToMmMultiple, 0F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 4F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-7.5F * Scale * _pixelToMmMultiple, -0.85F * -1 * Scale * _pixelToMmMultiple, 1F * Scale * _pixelToMmMultiple, 2.3F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-1F * Scale * _pixelToMmMultiple, 4F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 4F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-0.5F * Scale * _pixelToMmMultiple, 3.15F * -1 * Scale * _pixelToMmMultiple, 1F * Scale * _pixelToMmMultiple, 2.3F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(6F * Scale * _pixelToMmMultiple, 0F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 4F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(6.5F * Scale * _pixelToMmMultiple, -0.85F * -1 * Scale * _pixelToMmMultiple, 1F * Scale * _pixelToMmMultiple, 2.3F * Scale * _pixelToMmMultiple));
		}

		private void IEC60320_C19Path()
		{
			WidthF = 35F;
			HeightF = 27F;
			Path.AddRectangle(new RectangleF(-17.5F * Scale * _pixelToMmMultiple, 13.5F * -1 * Scale * _pixelToMmMultiple, 35F * Scale * _pixelToMmMultiple, 27F * Scale * _pixelToMmMultiple));
			Path.AddLines(new PointF[]{new PointF(-14F * Scale * _pixelToMmMultiple, 3F * -1 * Scale * _pixelToMmMultiple), new PointF(-6.221826F * Scale * _pixelToMmMultiple, 10F * -1 * Scale * _pixelToMmMultiple), new PointF(6.221826F * Scale * _pixelToMmMultiple, 10F * -1 * Scale * _pixelToMmMultiple), new PointF(14F * Scale * _pixelToMmMultiple, 3F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddArc(10.5F * Scale * _pixelToMmMultiple, -6.5F * -1 * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 360F, 90F);
			Path.AddArc(-14F * Scale * _pixelToMmMultiple, -6.5F * -1 * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 90F, 90F);
			Path.CloseFigure();
			Path.AddRectangle(new RectangleF(-10F * Scale * _pixelToMmMultiple, -2.75F * -1 * Scale * _pixelToMmMultiple, 7F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-3.5F * Scale * _pixelToMmMultiple, 5.25F * -1 * Scale * _pixelToMmMultiple, 7F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(3F * Scale * _pixelToMmMultiple, -2.75F * -1 * Scale * _pixelToMmMultiple, 7F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple));
		}

		private void IEC60320_C20Path()
		{
			WidthF = 35.5F;
			HeightF = 27.5F;
			Path.AddRectangle(new RectangleF(-17.75F * Scale * _pixelToMmMultiple, 13.75F * -1 * Scale * _pixelToMmMultiple, 35.5F * Scale * _pixelToMmMultiple, 27.5F * Scale * _pixelToMmMultiple));
			Path.AddLines(new PointF[]{new PointF(-14.5F * Scale * _pixelToMmMultiple, 3.5F * -1 * Scale * _pixelToMmMultiple), new PointF(-6.721826F * Scale * _pixelToMmMultiple, 10.5F * -1 * Scale * _pixelToMmMultiple), new PointF(6.721826F * Scale * _pixelToMmMultiple, 10.5F * -1 * Scale * _pixelToMmMultiple), new PointF(14.5F * Scale * _pixelToMmMultiple, 3.5F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddArc(11.5F * Scale * _pixelToMmMultiple, -7.5F * -1 * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 360F, 90F);
			Path.AddArc(-14.5F * Scale * _pixelToMmMultiple, -7.5F * -1 * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 90F, 90F);
			Path.CloseFigure();
			Path.AddRectangle(new RectangleF(-9F * Scale * _pixelToMmMultiple, -3F * -1 * Scale * _pixelToMmMultiple, 5F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-8.15F * Scale * _pixelToMmMultiple, -3.5F * -1 * Scale * _pixelToMmMultiple, 3.3F * Scale * _pixelToMmMultiple, 1F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-3F * Scale * _pixelToMmMultiple, 5F * -1 * Scale * _pixelToMmMultiple, 6F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-2.15F * Scale * _pixelToMmMultiple, 4.5F * -1 * Scale * _pixelToMmMultiple, 4.3F * Scale * _pixelToMmMultiple, 1F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(4F * Scale * _pixelToMmMultiple, -3F * -1 * Scale * _pixelToMmMultiple, 5F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(4.85F * Scale * _pixelToMmMultiple, -3.5F * -1 * Scale * _pixelToMmMultiple, 3.3F * Scale * _pixelToMmMultiple, 1F * Scale * _pixelToMmMultiple));
		}

		private void IEC60320_C21Path()
		{
			WidthF = 35F;
			HeightF = 27F;
			Path.AddRectangle(new RectangleF(-17.5F * Scale * _pixelToMmMultiple, 13.5F * -1 * Scale * _pixelToMmMultiple, 35F * Scale * _pixelToMmMultiple, 27F * Scale * _pixelToMmMultiple));
			Path.StartFigure();
			Path.AddArc(-14F * Scale * _pixelToMmMultiple, -6.5F * -1 * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 90F, 90F);
			Path.AddArc(-14F * Scale * _pixelToMmMultiple, 10F * -1 * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 180F, 90F);
			Path.AddArc(10.5F * Scale * _pixelToMmMultiple, 10F * -1 * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 270F, 90F);
			Path.AddArc(10.5F * Scale * _pixelToMmMultiple, -6.5F * -1 * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 360F, 90F);
			Path.CloseFigure();
			Path.AddRectangle(new RectangleF(-9.5F * Scale * _pixelToMmMultiple, -2.75F * -1 * Scale * _pixelToMmMultiple, 6F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-3.5F * Scale * _pixelToMmMultiple, 5.25F * -1 * Scale * _pixelToMmMultiple, 7F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(3.5F * Scale * _pixelToMmMultiple, -2.75F * -1 * Scale * _pixelToMmMultiple, 6F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple));
		}

		private void IEC60320_C22Path()
		{
			WidthF = 35.5F;
			HeightF = 27.5F;
			Path.AddRectangle(new RectangleF(-17.75F * Scale * _pixelToMmMultiple, 13.75F * -1 * Scale * _pixelToMmMultiple, 35.5F * Scale * _pixelToMmMultiple, 27.5F * Scale * _pixelToMmMultiple));
			Path.StartFigure();
			Path.AddArc(-14.5F * Scale * _pixelToMmMultiple, -7.5F * -1 * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 90F, 90F);
			Path.AddArc(-14.5F * Scale * _pixelToMmMultiple, 10.5F * -1 * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 180F, 90F);
			Path.AddArc(11.5F * Scale * _pixelToMmMultiple, 10.5F * -1 * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 270F, 90F);
			Path.AddArc(11.5F * Scale * _pixelToMmMultiple, -7.5F * -1 * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 360F, 90F);
			Path.CloseFigure();
			Path.AddRectangle(new RectangleF(-9F * Scale * _pixelToMmMultiple, -3F * -1 * Scale * _pixelToMmMultiple, 5F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-8.15F * Scale * _pixelToMmMultiple, -3.5F * -1 * Scale * _pixelToMmMultiple, 3.3F * Scale * _pixelToMmMultiple, 1F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-3F * Scale * _pixelToMmMultiple, 5F * -1 * Scale * _pixelToMmMultiple, 6F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-2.15F * Scale * _pixelToMmMultiple, 4.5F * -1 * Scale * _pixelToMmMultiple, 4.3F * Scale * _pixelToMmMultiple, 1F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(4F * Scale * _pixelToMmMultiple, -3F * -1 * Scale * _pixelToMmMultiple, 5F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(4.85F * Scale * _pixelToMmMultiple, -3.5F * -1 * Scale * _pixelToMmMultiple, 3.3F * Scale * _pixelToMmMultiple, 1F * Scale * _pixelToMmMultiple));
		}

		private void IEC60320_C23Path()
		{
			WidthF = 35F;
			HeightF = 27F;
			Path.AddRectangle(new RectangleF(-17.5F * Scale * _pixelToMmMultiple, 13.5F * -1 * Scale * _pixelToMmMultiple, 35F * Scale * _pixelToMmMultiple, 27F * Scale * _pixelToMmMultiple));
			Path.StartFigure();
			Path.AddArc(-14F * Scale * _pixelToMmMultiple, -6.5F * -1 * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 90F, 90F);
			Path.AddArc(-14F * Scale * _pixelToMmMultiple, 10F * -1 * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 180F, 90F);
			Path.AddArc(10.5F * Scale * _pixelToMmMultiple, 10F * -1 * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 270F, 90F);
			Path.AddArc(10.5F * Scale * _pixelToMmMultiple, -6.5F * -1 * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 3.5F * Scale * _pixelToMmMultiple, 360F, 90F);
			Path.CloseFigure();
			Path.AddRectangle(new RectangleF(-9.5F * Scale * _pixelToMmMultiple, -3F * -1 * Scale * _pixelToMmMultiple, 6F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(3.5F * Scale * _pixelToMmMultiple, -3F * -1 * Scale * _pixelToMmMultiple, 6F * Scale * _pixelToMmMultiple, 2.5F * Scale * _pixelToMmMultiple));
		}

		private void IEC60320_C24Path()
		{
			WidthF = 35.5F;
			HeightF = 27.5F;
			Path.AddRectangle(new RectangleF(-17.75F * Scale * _pixelToMmMultiple, 13.75F * -1 * Scale * _pixelToMmMultiple, 35.5F * Scale * _pixelToMmMultiple, 27.5F * Scale * _pixelToMmMultiple));
			Path.StartFigure();
			Path.AddArc(-14.5F * Scale * _pixelToMmMultiple, -7.5F * -1 * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 90F, 90F);
			Path.AddArc(-14.5F * Scale * _pixelToMmMultiple, 10.5F * -1 * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 180F, 90F);
			Path.AddArc(11.5F * Scale * _pixelToMmMultiple, 10.5F * -1 * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 270F, 90F);
			Path.AddArc(11.5F * Scale * _pixelToMmMultiple, -7.5F * -1 * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 360F, 90F);
			Path.CloseFigure();
			Path.AddRectangle(new RectangleF(-9F * Scale * _pixelToMmMultiple, -3F * -1 * Scale * _pixelToMmMultiple, 5F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(4F * Scale * _pixelToMmMultiple, -3F * -1 * Scale * _pixelToMmMultiple, 5F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple));
		}

		private void LugPath()
		{
			WidthF = 30F;
			HeightF = 87F;
			Path.AddLines(new PointF[]{new PointF(-10F * Scale * _pixelToMmMultiple, -43.5F * -1 * Scale * _pixelToMmMultiple), new PointF(-10F * Scale * _pixelToMmMultiple, 0.5F * -1 * Scale * _pixelToMmMultiple), new PointF(-10F * Scale * _pixelToMmMultiple, 15F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddArc(-15F * Scale * _pixelToMmMultiple, 43.5F * -1 * Scale * _pixelToMmMultiple, 30F * Scale * _pixelToMmMultiple, 30F * Scale * _pixelToMmMultiple, 131.9F, 276.4F);
			Path.AddLines(new PointF[]{new PointF(10F * Scale * _pixelToMmMultiple, 15F * -1 * Scale * _pixelToMmMultiple), new PointF(10F * Scale * _pixelToMmMultiple, 0.5F * -1 * Scale * _pixelToMmMultiple), new PointF(10F * Scale * _pixelToMmMultiple, -43.5F * -1 * Scale * _pixelToMmMultiple)});
			Path.StartFigure();
			Path.AddArc(-6.5F * Scale * _pixelToMmMultiple, 35F * -1 * Scale * _pixelToMmMultiple, 13F * Scale * _pixelToMmMultiple, 13F * Scale * _pixelToMmMultiple, 180F, 360F);
		}

		private void Nema_1_15PPath()
		{
			WidthF = 30F;
			HeightF = 30F;
			Path.AddArc(-15F * Scale * _pixelToMmMultiple, 15F * -1 * Scale * _pixelToMmMultiple, 30F * Scale * _pixelToMmMultiple, 30F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddRectangle(new RectangleF(-7.874F * Scale * _pixelToMmMultiple, 3.302F * -1 * Scale * _pixelToMmMultiple, 1.524F * Scale * _pixelToMmMultiple, 6.604F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(5.588F * Scale * _pixelToMmMultiple, 3.302F * -1 * Scale * _pixelToMmMultiple, 1.524F * Scale * _pixelToMmMultiple, 6.604F * Scale * _pixelToMmMultiple));
		}

		private void Nema_1_20PPath()
		{
			WidthF = 30F;
			HeightF = 30F;
			Path.AddArc(-15F * Scale * _pixelToMmMultiple, 15F * -1 * Scale * _pixelToMmMultiple, 30F * Scale * _pixelToMmMultiple, 30F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddRectangle(new RectangleF(5.588F * Scale * _pixelToMmMultiple, 3.302F * -1 * Scale * _pixelToMmMultiple, 1.524F * Scale * _pixelToMmMultiple, 6.604F * Scale * _pixelToMmMultiple));
			Path.AddArc(-8.588F * Scale * _pixelToMmMultiple, 0.7955F * -1 * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 270F, 90F);
			Path.AddLines(new PointF[]{new PointF(-5.588F * Scale * _pixelToMmMultiple, -3.302F * -1 * Scale * _pixelToMmMultiple), new PointF(-7.074001F * Scale * _pixelToMmMultiple, -3.302F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddArc(-10.112F * Scale * _pixelToMmMultiple, -0.4F * -1 * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 360F, -90F);
			Path.AddLines(new PointF[]{new PointF(-12.192F * Scale * _pixelToMmMultiple, -0.4F * -1 * Scale * _pixelToMmMultiple), new PointF(-12.192F * Scale * _pixelToMmMultiple, 0.8F * -1 * Scale * _pixelToMmMultiple)});
			Path.CloseFigure();
		}

		private void Nema_5_15PPath()
		{
			WidthF = 30F;
			HeightF = 30F;
			Path.AddArc(-15F * Scale * _pixelToMmMultiple, 15F * -1 * Scale * _pixelToMmMultiple, 30F * Scale * _pixelToMmMultiple, 30F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddRectangle(new RectangleF(-7.874F * Scale * _pixelToMmMultiple, 0.005F * -1 * Scale * _pixelToMmMultiple, 1.524F * Scale * _pixelToMmMultiple, 6.604F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(5.588F * Scale * _pixelToMmMultiple, 0.005F * -1 * Scale * _pixelToMmMultiple, 1.524F * Scale * _pixelToMmMultiple, 6.604F * Scale * _pixelToMmMultiple));
			Path.AddArc(-2.413F * Scale * _pixelToMmMultiple, 8.7122F * -1 * Scale * _pixelToMmMultiple, 4.826F * Scale * _pixelToMmMultiple, 4.826F * Scale * _pixelToMmMultiple, 180F, 360F);
		}

		private void Nema_5_20PPath()
		{
			WidthF = 30F;
			HeightF = 30F;
			Path.AddArc(-15F * Scale * _pixelToMmMultiple, 15F * -1 * Scale * _pixelToMmMultiple, 30F * Scale * _pixelToMmMultiple, 30F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddRectangle(new RectangleF(-7.874F * Scale * _pixelToMmMultiple, 0.005F * -1 * Scale * _pixelToMmMultiple, 1.524F * Scale * _pixelToMmMultiple, 6.604F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(5.588F * Scale * _pixelToMmMultiple, 0.005F * -1 * Scale * _pixelToMmMultiple, 1.524F * Scale * _pixelToMmMultiple, 6.604F * Scale * _pixelToMmMultiple));
			Path.AddArc(-2.413F * Scale * _pixelToMmMultiple, 8.7122F * -1 * Scale * _pixelToMmMultiple, 4.826F * Scale * _pixelToMmMultiple, 4.826F * Scale * _pixelToMmMultiple, 180F, 360F);
		}

		private void Nema_5_30PPath()
		{
			WidthF = 30F;
			HeightF = 30F;
			Path.AddArc(-15F * Scale * _pixelToMmMultiple, 15F * -1 * Scale * _pixelToMmMultiple, 30F * Scale * _pixelToMmMultiple, 30F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddRectangle(new RectangleF(5.588F * Scale * _pixelToMmMultiple, 0.005F * -1 * Scale * _pixelToMmMultiple, 1.524F * Scale * _pixelToMmMultiple, 6.604F * Scale * _pixelToMmMultiple));
			Path.AddArc(-2.413F * Scale * _pixelToMmMultiple, 8.7122F * -1 * Scale * _pixelToMmMultiple, 4.826F * Scale * _pixelToMmMultiple, 4.826F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(-8.5F * Scale * _pixelToMmMultiple, -3F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 180F, 90F);
			Path.AddLines(new PointF[]{new PointF(-3.5F * Scale * _pixelToMmMultiple, -3F * -1 * Scale * _pixelToMmMultiple), new PointF(-3.5F * Scale * _pixelToMmMultiple, -4.2F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddArc(-7.5F * Scale * _pixelToMmMultiple, -4.2F * -1 * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 2F * Scale * _pixelToMmMultiple, 270F, -90F);
			Path.AddLines(new PointF[]{new PointF(-7.5F * Scale * _pixelToMmMultiple, -8F * -1 * Scale * _pixelToMmMultiple), new PointF(-8.5F * Scale * _pixelToMmMultiple, -8F * -1 * Scale * _pixelToMmMultiple)});
			Path.CloseFigure();
		}

		private void Nema_5_50PPath()
		{
			WidthF = 30F;
			HeightF = 30F;
			Path.AddArc(-15F * Scale * _pixelToMmMultiple, 15F * -1 * Scale * _pixelToMmMultiple, 30F * Scale * _pixelToMmMultiple, 30F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddRectangle(new RectangleF(-7.874F * Scale * _pixelToMmMultiple, 3.302F * -1 * Scale * _pixelToMmMultiple, 1.524F * Scale * _pixelToMmMultiple, 6.604F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(5.588F * Scale * _pixelToMmMultiple, 3.302F * -1 * Scale * _pixelToMmMultiple, 1.524F * Scale * _pixelToMmMultiple, 6.604F * Scale * _pixelToMmMultiple));
		}

		private void Nema_6_50PPath()
		{
			WidthF = 30F;
			HeightF = 30F;
			Path.AddArc(-15F * Scale * _pixelToMmMultiple, 15F * -1 * Scale * _pixelToMmMultiple, 30F * Scale * _pixelToMmMultiple, 30F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddRectangle(new RectangleF(-7.874F * Scale * _pixelToMmMultiple, 3.302F * -1 * Scale * _pixelToMmMultiple, 1.524F * Scale * _pixelToMmMultiple, 6.604F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(5.588F * Scale * _pixelToMmMultiple, 3.302F * -1 * Scale * _pixelToMmMultiple, 1.524F * Scale * _pixelToMmMultiple, 6.604F * Scale * _pixelToMmMultiple));
		}

		private void PowerSupplyVoltageSwitchPath()
		{
			WidthF = 7F;
			HeightF = 12F;
			Path.AddRectangle(new RectangleF(-3.5F * Scale * _pixelToMmMultiple, 6F * -1 * Scale * _pixelToMmMultiple, 7F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-2.5F * Scale * _pixelToMmMultiple, 5F * -1 * Scale * _pixelToMmMultiple, 5F * Scale * _pixelToMmMultiple, 10F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-2F * Scale * _pixelToMmMultiple, -1F * -1 * Scale * _pixelToMmMultiple, 0.4F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple));
			Path.AddRectangle(new RectangleF(-0.8F * Scale * _pixelToMmMultiple, -1F * -1 * Scale * _pixelToMmMultiple, 0.4F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple));
			Path.StartFigure();
			Path.AddLines(new PointF[]{new PointF(0.5F * Scale * _pixelToMmMultiple, -1F * -1 * Scale * _pixelToMmMultiple), new PointF(1.7F * Scale * _pixelToMmMultiple, -1F * -1 * Scale * _pixelToMmMultiple), new PointF(1.7F * Scale * _pixelToMmMultiple, -1.3F * -1 * Scale * _pixelToMmMultiple), new PointF(0.6F * Scale * _pixelToMmMultiple, -1.3F * -1 * Scale * _pixelToMmMultiple), new PointF(0.6F * Scale * _pixelToMmMultiple, -2.2F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddArc(0F * Scale * _pixelToMmMultiple, -2.18F * -1 * Scale * _pixelToMmMultiple, 1.8F * Scale * _pixelToMmMultiple, 1.8F * Scale * _pixelToMmMultiple, 270F, 180F);
			Path.AddLines(new PointF[]{new PointF(0.3F * Scale * _pixelToMmMultiple, -4F * -1 * Scale * _pixelToMmMultiple), new PointF(0.3F * Scale * _pixelToMmMultiple, -1F * -1 * Scale * _pixelToMmMultiple)});
			Path.CloseFigure();
			Path.AddArc(0.1F * Scale * _pixelToMmMultiple, -2.38F * -1 * Scale * _pixelToMmMultiple, 1.4F * Scale * _pixelToMmMultiple, 1.4F * Scale * _pixelToMmMultiple, 270F, 180F);
			Path.AddRectangle(new RectangleF(0.3F * Scale * _pixelToMmMultiple, -2.4F * -1 * Scale * _pixelToMmMultiple, 0.5F * Scale * _pixelToMmMultiple, 1.4F * Scale * _pixelToMmMultiple));
			Path.AddArc(-1.9F * Scale * _pixelToMmMultiple, 3.8F * -1 * Scale * _pixelToMmMultiple, 1.1F * Scale * _pixelToMmMultiple, 1.1F * Scale * _pixelToMmMultiple, 180F, 180F);
			Path.AddLines(new PointF[]{new PointF(-2.1F * Scale * _pixelToMmMultiple, 1.3F * -1 * Scale * _pixelToMmMultiple), new PointF(-2.1F * Scale * _pixelToMmMultiple, 1F * -1 * Scale * _pixelToMmMultiple), new PointF(-0.6F * Scale * _pixelToMmMultiple, 1F * -1 * Scale * _pixelToMmMultiple), new PointF(-0.6F * Scale * _pixelToMmMultiple, 1.3F * -1 * Scale * _pixelToMmMultiple), new PointF(-1.9F * Scale * _pixelToMmMultiple, 1.3F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddArc(-2.1F * Scale * _pixelToMmMultiple, 4F * -1 * Scale * _pixelToMmMultiple, 1.5F * Scale * _pixelToMmMultiple, 1.5F * Scale * _pixelToMmMultiple, 0F, -180F);
			Path.CloseFigure();
			Path.AddLines(new PointF[]{new PointF(-0.5F * Scale * _pixelToMmMultiple, 3.7F * -1 * Scale * _pixelToMmMultiple), new PointF(-0.5F * Scale * _pixelToMmMultiple, 3.99F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddArc(-1F * Scale * _pixelToMmMultiple, 4F * -1 * Scale * _pixelToMmMultiple, 1.8F * Scale * _pixelToMmMultiple, 1.8F * Scale * _pixelToMmMultiple, 280F, 120F);
			Path.AddArc(-1F * Scale * _pixelToMmMultiple, 2.8F * -1 * Scale * _pixelToMmMultiple, 1.8F * Scale * _pixelToMmMultiple, 1.8F * Scale * _pixelToMmMultiple, 318F, 130F);
			Path.AddLines(new PointF[]{new PointF(-0.5F * Scale * _pixelToMmMultiple, 1F * -1 * Scale * _pixelToMmMultiple), new PointF(-0.5F * Scale * _pixelToMmMultiple, 1.3F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddArc(-0.7F * Scale * _pixelToMmMultiple, 2.5F * -1 * Scale * _pixelToMmMultiple, 1.2F * Scale * _pixelToMmMultiple, 1.2F * Scale * _pixelToMmMultiple, 90F, -180F);
			Path.AddArc(-0.7F * Scale * _pixelToMmMultiple, 3.7F * -1 * Scale * _pixelToMmMultiple, 1.2F * Scale * _pixelToMmMultiple, 1.2F * Scale * _pixelToMmMultiple, 90F, -180F);
			Path.CloseFigure();
			Path.AddArc(0.9F * Scale * _pixelToMmMultiple, 4F * -1 * Scale * _pixelToMmMultiple, 1.5F * Scale * _pixelToMmMultiple, 3F * Scale * _pixelToMmMultiple, 180F, 360F);
			Path.AddArc(1.1F * Scale * _pixelToMmMultiple, 3.8F * -1 * Scale * _pixelToMmMultiple, 1.1F * Scale * _pixelToMmMultiple, 2.6F * Scale * _pixelToMmMultiple, 180F, 360F);
		}

		private void RingPath()
		{
			WidthF = 9.4F;
			HeightF = 17F;
			Path.AddLines(new PointF[]{new PointF(-3.2F * Scale * _pixelToMmMultiple, -8.5F * -1 * Scale * _pixelToMmMultiple), new PointF(-3.2F * Scale * _pixelToMmMultiple, -1.5F * -1 * Scale * _pixelToMmMultiple)});
			Path.AddArc(-4.7F * Scale * _pixelToMmMultiple, 8.5F * -1 * Scale * _pixelToMmMultiple, 9.4F * Scale * _pixelToMmMultiple, 9.4F * Scale * _pixelToMmMultiple, 170F, 200F);
			Path.AddLines(new PointF[]{new PointF(3.2F * Scale * _pixelToMmMultiple, -1.5F * -1 * Scale * _pixelToMmMultiple), new PointF(3.2F * Scale * _pixelToMmMultiple, -8.5F * -1 * Scale * _pixelToMmMultiple)});
			Path.StartFigure();
			Path.AddArc(-3.2F * Scale * _pixelToMmMultiple, 7F * -1 * Scale * _pixelToMmMultiple, 6.4F * Scale * _pixelToMmMultiple, 6.4F * Scale * _pixelToMmMultiple, 180F, 360F);
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "Ports";
			return new ShapeType("Power", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new Power(s, t); },
			Power.GetPropertyDefinitions, Windstream.NShape.Ports.Properties.Resources.Power);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			WidthF = 4.5F;
			HeightF = 19.5F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int PowerMiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.PowerMiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.PowerMiddleCenter);
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
				case ControlPointIds.PowerMiddleCenter:
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