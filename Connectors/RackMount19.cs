using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using Dataweb.NShape;
using Dataweb.NShape.Advanced;

namespace Windstream.Shapes.NShape.Electrical.Connectors
{

	public class RackMount19 : RectangleFBase
	{

		#region Constructors

		protected internal RackMount19(ShapeType shapeType, Template template)
			: base(shapeType, template)
		{
			WidthF = 483F;
			HeightF = 2130F;
		}

		protected internal RackMount19(ShapeType shapeType, IStyleSet styleSet)
			: base(shapeType, styleSet)
		{
			WidthF = 483F;
			HeightF = 2130F;
		}

		#endregion Constructors

		#region Required Methods

		public override Shape Clone()
		{
			Shape result = new RackMount19(Type, Template);
			result.CopyFrom(this);
			return result;
		}

		protected override bool CalculatePath()
		{
			if (base.CalculatePath())
			{
				Path.Reset();
				Path.AddRectangle(new RectangleF(-241.5F * Scale * _pixelToMmMultiple, 1065F * -1 * Scale * _pixelToMmMultiple, 483F * Scale * _pixelToMmMultiple, 2130F * Scale * _pixelToMmMultiple));
				Path.AddRectangle(new RectangleF(-225.625F * Scale * _pixelToMmMultiple, 1050F * -1 * Scale * _pixelToMmMultiple, 451.25F * Scale * _pixelToMmMultiple, 2100F * Scale * _pixelToMmMultiple));
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 1000F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 984.125F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 968.25F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 955.55F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 939.675F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 923.8F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 911.1F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 895.225F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 879.35F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 866.65F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 850.775F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 834.9F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 822.2F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 806.325F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 790.45F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 777.7499F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 761.8749F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 745.9999F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 733.2999F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 717.4249F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 701.5499F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 688.8499F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 672.9749F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 657.0999F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 644.3999F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 628.5249F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 612.6499F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 599.9499F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 584.0749F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 568.1999F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 555.4999F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 539.6249F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 523.7499F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 511.0499F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 495.1749F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 479.2999F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 466.5999F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 450.7249F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 434.8499F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 422.1498F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 406.2748F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 390.3998F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 377.6998F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 361.8248F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 345.9498F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 333.2498F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 317.3748F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 301.4998F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 288.7998F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 272.9248F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 257.0498F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 244.3498F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 228.4748F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 212.5998F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 199.8998F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 184.0248F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 168.1498F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 155.4498F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 139.5748F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 123.6998F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 110.9998F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 95.12482F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 79.24982F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 66.54982F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 50.67482F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 34.79982F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 22.09982F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, 6.224819F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -9.650181F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -22.35018F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -38.22518F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -54.10018F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -66.80018F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -82.67518F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -98.55018F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -111.2502F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -127.1252F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -143.0002F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -155.7002F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -171.5752F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -187.4502F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -200.1502F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -216.0252F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -231.9002F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -244.6002F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -260.4752F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -276.3502F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -289.0502F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -304.9252F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -320.8002F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -333.5002F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -349.3752F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -365.2502F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -377.9502F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -393.8252F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -409.7002F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -422.4002F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -438.2752F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -454.1502F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -466.8502F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -482.7252F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -498.6002F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -511.3002F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -527.1752F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -543.0502F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -555.7502F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -571.6252F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -587.5002F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -600.2003F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -616.0753F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -631.9503F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -644.6503F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -660.5253F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -676.4003F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -689.1003F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -704.9753F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -720.8503F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -733.5503F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -749.4253F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -765.3003F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -778.0003F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -793.8753F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -809.7503F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -822.4503F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -838.3253F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -854.2003F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -866.9003F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -882.7753F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -898.6503F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -911.3503F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -927.2253F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -943.1003F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -955.8004F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -971.6754F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -987.5504F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(-239.5625F * Scale * _pixelToMmMultiple, -1000.25F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 1000F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 984.125F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 968.25F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 955.55F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 939.675F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 923.8F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 911.1F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 895.225F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 879.35F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 866.65F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 850.775F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 834.9F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 822.2F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 806.325F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 790.45F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 777.7499F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 761.8749F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 745.9999F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 733.2999F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 717.4249F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 701.5499F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 688.8499F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 672.9749F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 657.0999F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 644.3999F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 628.5249F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 612.6499F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 599.9499F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 584.0749F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 568.1999F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 555.4999F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 539.6249F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 523.7499F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 511.0499F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 495.1749F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 479.2999F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 466.5999F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 450.7249F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 434.8499F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 422.1498F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 406.2748F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 390.3998F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 377.6998F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 361.8248F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 345.9498F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 333.2498F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 317.3748F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 301.4998F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 288.7998F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 272.9248F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 257.0498F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 244.3498F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 228.4748F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 212.5998F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 199.8998F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 184.0248F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 168.1498F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 155.4498F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 139.5748F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 123.6998F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 110.9998F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 95.12482F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 79.24982F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 66.54982F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 50.67482F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 34.79982F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 22.09982F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, 6.224819F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -9.650181F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -22.35018F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -38.22518F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -54.10018F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -66.80018F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -82.67518F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -98.55018F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -111.2502F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -127.1252F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -143.0002F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -155.7002F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -171.5752F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -187.4502F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -200.1502F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -216.0252F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -231.9002F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -244.6002F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -260.4752F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -276.3502F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -289.0502F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -304.9252F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -320.8002F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -333.5002F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -349.3752F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -365.2502F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -377.9502F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -393.8252F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -409.7002F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -422.4002F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -438.2752F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -454.1502F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -466.8502F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -482.7252F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -498.6002F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -511.3002F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -527.1752F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -543.0502F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -555.7502F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -571.6252F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -587.5002F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -600.2003F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -616.0753F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -631.9503F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -644.6503F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -660.5253F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -676.4003F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -689.1003F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -704.9753F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -720.8503F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -733.5503F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -749.4253F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -765.3003F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -778.0003F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -793.8753F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -809.7503F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -822.4503F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -838.3253F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -854.2003F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -866.9003F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -882.7753F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -898.6503F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -911.3503F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -927.2253F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -943.1003F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -955.8004F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -971.6754F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -987.5504F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				Path.AddArc(227.5625F * Scale * _pixelToMmMultiple, -1000.25F * -1 * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 12F * Scale * _pixelToMmMultiple, 180F, 360F);
				return true;
			}
			return false;
		}

		public static ShapeType GetShapeType()
		{
			string libraryName = "ElectricalConnectors";
			return new ShapeType("RackMount19", libraryName, libraryName,
					delegate(ShapeType s, Template t) { return new RackMount19(s, t); },
			RectangleFBase.GetPropertyDefinitions, Windstream.Shapes.NShape.Electrical.Connectors.Properties.Resources.RackMount19);
		}

		protected override void InitializeToDefault(IStyleSet styleSet)
		{
			base.InitializeToDefault(styleSet);
			WidthF = 483F;
			HeightF = 2130F;
		}

		#endregion Required Methods

		#region ControlPoints

		#region Required Sub-Class

		new public class ControlPointIds
		{
			public const int Reference = ControlPointId.Reference;
			public const int MiddleCenter = 1;
			public const int RackMount19MiddleCenter = 2;
		}

		#endregion Required Sub-Class

		protected override void CalcControlPoints()
		{
			ControlPoints[ControlPointIds.Reference] = Point.Empty;
			ControlPoints[ControlPointIds.MiddleCenter] = Point.Empty;
			ControlPoints[ControlPointIds.RackMount19MiddleCenter] = Point.Empty;
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
				returnValue.Add(ControlPointIds.RackMount19MiddleCenter);
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
				case ControlPointIds.RackMount19MiddleCenter:
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
