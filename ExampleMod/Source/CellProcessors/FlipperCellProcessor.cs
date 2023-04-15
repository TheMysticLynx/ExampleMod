using Modding;
using Modding.PublicInterfaces.Cells;

namespace Indev2
{
    public class FlipperCellProcessor : RotatorProcessor
    {
        public FlipperCellProcessor(ICellGrid cellGrid) : base(cellGrid)
        {
        }

        public override string Name => "CCW Rotator";
        public override int CellType => 9;
        public override string CellSpriteIndex => "Flipper";
        public override int RotationAmount => 2;
        public override void OnCellInit(ref BasicCell cell)
        {
        }

        public override void Clear()
        {
        }
    }
}