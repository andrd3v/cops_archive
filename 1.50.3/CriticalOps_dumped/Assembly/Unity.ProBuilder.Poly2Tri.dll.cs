// Namespace: 
internal class <Module>
{}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class Polygon
{
	// Fields
	protected System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> _points; // 0x10
	protected System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> _steinerPoints; // 0x18
	protected System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.Polygon> _holes; // 0x20
	protected System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> _triangles; // 0x28

	// Methods

	// RVA: 0x14FA254
	public void .ctor(System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.PolygonPoint> points) { }

	// RVA: 0x14FA63C
	public void .ctor(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Poly2Tri.PolygonPoint> points) { }

	// RVA: 0x14FA6F0
	public TriangulationMode get_TriangulationMode() { }

	// RVA: 0x14FA6F8
	public void AddHole(Polygon poly) { }

	// RVA: 0x14FA7B0
	public System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> get_Triangles() { }

	// RVA: 0x14FA7B8
	public void AddTriangle(DelaunayTriangle t) { }

	// RVA: 0x14FA81C
	public void AddTriangles(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> list) { }

	// RVA: 0x14FA880
	public void Prepare(TriangulationContext tcx) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class PolygonPoint
{
	// Methods

	// RVA: 0x14FADA0
	public void .ctor(Double x, Double y, int index) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DelaunayTriangle
{
	// Fields
	public UnityEngine.ProBuilder.Poly2Tri.FixedArray3<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> Points; // 0x10
	public UnityEngine.ProBuilder.Poly2Tri.FixedArray3<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> Neighbors; // 0x28
	public FixedBitArray3 EdgeIsConstrained; // 0x40
	public FixedBitArray3 EdgeIsDelaunay; // 0x43
	private bool <IsInterior>k__BackingField; // 0x46

	// Methods

	// RVA: 0x14FAE20
	public bool get_IsInterior() { }

	// RVA: 0x14FAE28
	public void set_IsInterior(bool value) { }

	// RVA: 0x14FAE30
	public void .ctor(TriangulationPoint p1, TriangulationPoint p2, TriangulationPoint p3) { }

	// RVA: 0x14FAED8
	public int IndexOf(TriangulationPoint p) { }

	// RVA: 0x14FAF88
	public int IndexCCWFrom(TriangulationPoint p) { }

	// RVA: 0x14FAFC0
	public bool Contains(TriangulationPoint p) { }

	// RVA: 0x14FB01C
	private void MarkNeighbor(TriangulationPoint p1, TriangulationPoint p2, DelaunayTriangle t) { }

	// RVA: 0x14FB264
	public void MarkNeighbor(DelaunayTriangle t) { }

	// RVA: 0x14FB494
	public TriangulationPoint OppositePoint(DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0x14FB620
	public DelaunayTriangle NeighborCWFrom(TriangulationPoint point) { }

	// RVA: 0x14FB6CC
	public DelaunayTriangle NeighborCCWFrom(TriangulationPoint point) { }

	// RVA: 0x14FB778
	public DelaunayTriangle NeighborAcrossFrom(TriangulationPoint point) { }

	// RVA: 0x14FB804
	public TriangulationPoint PointCCWFrom(TriangulationPoint point) { }

	// RVA: 0x14FB594
	public TriangulationPoint PointCWFrom(TriangulationPoint point) { }

	// RVA: 0x14FB890
	private void RotateCW() { }

	// RVA: 0x14FB960
	public void Legalize(TriangulationPoint oPoint, TriangulationPoint nPoint) { }

	// RVA: 0x14FBA04
	public override string ToString() { }

	// RVA: 0x14FBBC4
	public void MarkConstrainedEdge(int index) { }

	// RVA: 0x14FBCD8
	public void MarkConstrainedEdge(TriangulationPoint p, TriangulationPoint q) { }

	// RVA: 0x14FB170
	public int EdgeIndex(TriangulationPoint p1, TriangulationPoint p2) { }

	// RVA: 0x14FBDB4
	public bool GetConstrainedEdgeCCW(TriangulationPoint p) { }

	// RVA: 0x14FBEEC
	public bool GetConstrainedEdgeCW(TriangulationPoint p) { }

	// RVA: 0x14FBFA8
	public void SetConstrainedEdgeCCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x14FC068
	public void SetConstrainedEdgeCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x14FC128
	public bool GetDelaunayEdgeCCW(TriangulationPoint p) { }

	// RVA: 0x14FC1E4
	public bool GetDelaunayEdgeCW(TriangulationPoint p) { }

	// RVA: 0x14FC2A0
	public void SetDelaunayEdgeCCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x14FC360
	public void SetDelaunayEdgeCW(TriangulationPoint p, bool ce) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class AdvancingFront
{
	// Fields
	public AdvancingFrontNode Head; // 0x10
	public AdvancingFrontNode Tail; // 0x18
	protected AdvancingFrontNode Search; // 0x20

	// Methods

	// RVA: 0x14FC420
	public void .ctor(AdvancingFrontNode head, AdvancingFrontNode tail) { }

	// RVA: 0x14FC480
	public void AddNode(AdvancingFrontNode node) { }

	// RVA: 0x14FC484
	public void RemoveNode(AdvancingFrontNode node) { }

	// RVA: 0x14FC488
	public override string ToString() { }

	// RVA: 0x14FC584
	private AdvancingFrontNode FindSearchNode(Double x) { }

	// RVA: 0x14FC58C
	public AdvancingFrontNode LocateNode(TriangulationPoint point) { }

	// RVA: 0x14FC61C
	private AdvancingFrontNode LocateNode(Double x) { }

	// RVA: 0x14FC6A4
	public AdvancingFrontNode LocatePoint(TriangulationPoint point) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class AdvancingFrontNode
{
	// Fields
	public AdvancingFrontNode Next; // 0x10
	public AdvancingFrontNode Prev; // 0x18
	public Double Value; // 0x20
	public TriangulationPoint Point; // 0x28
	public DelaunayTriangle Triangle; // 0x30

	// Methods

	// RVA: 0x14FC7A8
	public void .ctor(TriangulationPoint point) { }

	// RVA: 0x14FC7F0
	public bool get_HasNext() { }

	// RVA: 0x14FC800
	public bool get_HasPrev() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal static class DTSweep
{
	// Methods

	// RVA: 0x14FC810
	public static void Triangulate(DTSweepContext tcx) { }

	// RVA: 0x14FCBA8
	private static void Sweep(DTSweepContext tcx) { }

	// RVA: 0x14FD06C
	private static void FinalizationConvexHull(DTSweepContext tcx) { }

	// RVA: 0x14FDC60
	private static void TurnAdvancingFrontConvex(DTSweepContext tcx, AdvancingFrontNode b, AdvancingFrontNode c) { }

	// RVA: 0x14FCED8
	private static void FinalizationPolygon(DTSweepContext tcx) { }

	// RVA: 0x14FD718
	private static AdvancingFrontNode PointEvent(DTSweepContext tcx, TriangulationPoint point) { }

	// RVA: 0x14FF00C
	private static AdvancingFrontNode NewFrontTriangle(DTSweepContext tcx, TriangulationPoint point, AdvancingFrontNode node) { }

	// RVA: 0x14FD9C8
	private static void EdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x14FFAB0
	private static void FillEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x1500244
	private static void FillRightConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x15003A8
	private static void FillRightConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x1500558
	private static void FillRightBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x14FFE98
	private static void FillRightAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x1500800
	private static void FillLeftConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x15009A4
	private static void FillLeftConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x1500B00
	private static void FillLeftBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x1500070
	private static void FillLeftAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x14FF8CC
	private static bool IsEdgeSideOfTriangle(DelaunayTriangle triangle, TriangulationPoint ep, TriangulationPoint eq) { }

	// RVA: 0x14FFAE0
	private static void EdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle triangle, TriangulationPoint point) { }

	// RVA: 0x1500E08
	private static void FlipEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0x15018D0
	private static TriangulationPoint NextFlipPoint(TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle ot, TriangulationPoint op) { }

	// RVA: 0x15016D4
	private static DelaunayTriangle NextFlipTriangle(DTSweepContext tcx, Orientation o, DelaunayTriangle t, DelaunayTriangle ot, TriangulationPoint p, TriangulationPoint op) { }

	// RVA: 0x1501AAC
	private static void FlipScanEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle flipTriangle, DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0x14FF2C4
	private static void FillAdvancingFront(DTSweepContext tcx, AdvancingFrontNode n) { }

	// RVA: 0x15020C8
	private static void FillBasin(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x15022DC
	private static void FillBasinReq(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x15024B8
	private static bool IsShallow(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x1501F5C
	private static Double HoleAngle(AdvancingFrontNode node) { }

	// RVA: 0x150202C
	private static Double BasinAngle(AdvancingFrontNode node) { }

	// RVA: 0x14FEDBC
	private static void Fill(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x14FF3CC
	private static bool Legalize(DTSweepContext tcx, DelaunayTriangle t) { }

	// RVA: 0x14FDE64
	private static void RotateTrianglePair(DelaunayTriangle t, TriangulationPoint p, DelaunayTriangle ot, TriangulationPoint op) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepBasin
{
	// Fields
	public AdvancingFrontNode leftNode; // 0x10
	public AdvancingFrontNode bottomNode; // 0x18
	public AdvancingFrontNode rightNode; // 0x20
	public Double width; // 0x28
	public bool leftHighest; // 0x30

	// Methods

	// RVA: 0x1502610
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepConstraint
{
	// Methods

	// RVA: 0x1502618
	public void .ctor(TriangulationPoint p1, TriangulationPoint p2) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepContext
{
	// Fields
	private readonly float ALPHA; // 0x40
	public AdvancingFront Front; // 0x48
	private TriangulationPoint <Head>k__BackingField; // 0x50
	private TriangulationPoint <Tail>k__BackingField; // 0x58
	public DTSweepBasin Basin; // 0x60
	public DTSweepEdgeEvent EdgeEvent; // 0x68
	private DTSweepPointComparator _comparator; // 0x70

	// Methods

	// RVA: 0x1502798
	public TriangulationPoint get_Head() { }

	// RVA: 0x15027A0
	public void set_Head(TriangulationPoint value) { }

	// RVA: 0x15027A8
	public TriangulationPoint get_Tail() { }

	// RVA: 0x15027B0
	public void set_Tail(TriangulationPoint value) { }

	// RVA: 0x15027B8
	public void .ctor() { }

	// RVA: 0x15029B0
	public override bool get_IsDebugEnabled() { }

	// RVA: 0x14FEA98
	public void RemoveFromList(DelaunayTriangle triangle) { }

	// RVA: 0x14FEF70
	public void MeshClean(DelaunayTriangle triangle) { }

	// RVA: 0x15029B8
	private void MeshCleanReq(DelaunayTriangle triangle) { }

	// RVA: 0x1502B28
	public override void Clear() { }

	// RVA: 0x14FF2A8
	public void AddNode(AdvancingFrontNode node) { }

	// RVA: 0x1502528
	public void RemoveNode(AdvancingFrontNode node) { }

	// RVA: 0x14FEF74
	public AdvancingFrontNode LocateNode(TriangulationPoint point) { }

	// RVA: 0x14FC87C
	public void CreateAdvancingFront() { }

	// RVA: 0x14FE7EC
	public void MapTriangleToNodes(DelaunayTriangle t) { }

	// RVA: 0x1502C84
	public override void PrepareTriangulation(Triangulatable t) { }

	// RVA: 0x14FEAFC
	public void FinalizeTriangulation() { }

	// RVA: 0x15030E4
	public override TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepDebugContext
{
	// Fields
	private DelaunayTriangle _primaryTriangle; // 0x18
	private DelaunayTriangle _secondaryTriangle; // 0x20
	private TriangulationPoint _activePoint; // 0x28
	private AdvancingFrontNode _activeNode; // 0x30
	private DTSweepConstraint _activeConstraint; // 0x38

	// Methods

	// RVA: 0x14FF868
	public void set_PrimaryTriangle(DelaunayTriangle value) { }

	// RVA: 0x15015F0
	public void set_SecondaryTriangle(DelaunayTriangle value) { }

	// RVA: 0x1503150
	public void set_ActivePoint(TriangulationPoint value) { }

	// RVA: 0x14FEC3C
	public void set_ActiveNode(AdvancingFrontNode value) { }

	// RVA: 0x14FD964
	public void set_ActiveConstraint(DTSweepConstraint value) { }

	// RVA: 0x15031B4
	public override void Clear() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepEdgeEvent
{
	// Fields
	public DTSweepConstraint ConstrainedEdge; // 0x10
	public bool Right; // 0x18

	// Methods

	// RVA: 0x15028C0
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepPointComparator
{
	// Methods

	// RVA: 0x15032FC
	public int Compare(TriangulationPoint p1, TriangulationPoint p2) { }

	// RVA: 0x15028C8
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class PointOnEdgeException
{
	// Fields
	public readonly TriangulationPoint A; // 0x90
	public readonly TriangulationPoint B; // 0x98
	public readonly TriangulationPoint C; // 0xA0

	// Methods

	// RVA: 0x1500DA4
	public void .ctor(string message, TriangulationPoint a, TriangulationPoint b, TriangulationPoint c) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal interface Triangulatable
{
	// Methods

	// RVA: -1
	public abstract void Prepare(TriangulationContext tcx) { }

	// RVA: -1
	public abstract System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> get_Triangles() { }

	// RVA: -1
	public abstract void AddTriangle(DelaunayTriangle t) { }

	// RVA: -1
	public abstract void AddTriangles(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> list) { }

	// RVA: -1
	public abstract TriangulationMode get_TriangulationMode() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal enum Orientation
{
	// Fields
	public int value__; // 0x10
	public const Orientation CW = 0;
	public const Orientation CCW = 1;
	public const Orientation Collinear = 2;
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class PointSet
{
	// Fields
	private System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> <Points>k__BackingField; // 0x10
	private System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> <Triangles>k__BackingField; // 0x18

	// Methods

	// RVA: 0x1503368
	public System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> get_Points() { }

	// RVA: 0x1503370
	private void set_Points(System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> value) { }

	// RVA: 0x1503378
	public System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> get_Triangles() { }

	// RVA: 0x1503380
	private void set_Triangles(System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> value) { }

	// RVA: 0x1503388
	public void .ctor(System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> points) { }

	// RVA: 0x1503424
	public virtual TriangulationMode get_TriangulationMode() { }

	// RVA: 0x150342C
	public void AddTriangle(DelaunayTriangle t) { }

	// RVA: 0x15034E4
	public void AddTriangles(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> list) { }

	// RVA: 0x1503828
	public virtual void Prepare(TriangulationContext tcx) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class TriangulationConstraint
{
	// Fields
	public TriangulationPoint P; // 0x10
	public TriangulationPoint Q; // 0x18

	// Methods

	// RVA: 0x15026D8
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal abstract class TriangulationContext
{
	// Fields
	private TriangulationDebugContext <DebugContext>k__BackingField; // 0x10
	public readonly System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> Triangles; // 0x18
	public readonly System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> Points; // 0x20
	private TriangulationMode <TriangulationMode>k__BackingField; // 0x28
	private Triangulatable <Triangulatable>k__BackingField; // 0x30
	private int <StepCount>k__BackingField; // 0x38
	private bool <IsDebugEnabled>k__BackingField; // 0x3C

	// Methods

	// RVA: 0x15039F4
	public TriangulationDebugContext get_DebugContext() { }

	// RVA: 0x15039FC
	public TriangulationMode get_TriangulationMode() { }

	// RVA: 0x1503A04
	protected void set_TriangulationMode(TriangulationMode value) { }

	// RVA: 0x1503A0C
	public Triangulatable get_Triangulatable() { }

	// RVA: 0x1503A14
	private void set_Triangulatable(Triangulatable value) { }

	// RVA: 0x1503A1C
	public int get_StepCount() { }

	// RVA: 0x1503A24
	private void set_StepCount(int value) { }

	// RVA: 0x14FD708
	public void Done() { }

	// RVA: 0x1502FC4
	public virtual void PrepareTriangulation(Triangulatable t) { }

	// RVA: -1
	public abstract TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b) { }

	// RVA: 0x14FDC5C
	public void Update(string message) { }

	// RVA: 0x1502BD0
	public virtual void Clear() { }

	// RVA: 0x1503A2C
	public virtual bool get_IsDebugEnabled() { }

	// RVA: 0x14FD8DC
	public DTSweepDebugContext get_DTDebugContext() { }

	// RVA: 0x15028D0
	protected void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal abstract class TriangulationDebugContext
{
	// Fields
	protected TriangulationContext _tcx; // 0x10

	// Methods

	// RVA: -1
	public abstract void Clear() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal enum TriangulationMode
{
	// Fields
	public int value__; // 0x10
	public const TriangulationMode Unconstrained = 0;
	public const TriangulationMode Constrained = 1;
	public const TriangulationMode Polygon = 2;
}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class TriangulationPoint
{
	// Fields
	private System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.DTSweepConstraint> <Edges>k__BackingField; // 0x10
	public Double X; // 0x18
	public Double Y; // 0x20
	public int Index; // 0x28

	// Methods

	// RVA: 0x1503A34
	public System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.DTSweepConstraint> get_Edges() { }

	// RVA: 0x1503A3C
	private void set_Edges(System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.DTSweepConstraint> value) { }

	// RVA: 0x14FADE0
	public void .ctor(Double x, Double y, int index) { }

	// RVA: 0x1503A44
	public override string ToString() { }

	// RVA: 0x15026E0
	public void AddEdge(DTSweepConstraint e) { }

	// RVA: 0x14FD8CC
	public bool get_HasEdges() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class TriangulationUtil
{
	// Fields
	public static Double EPSILON; // 0x0

	// Methods

	// RVA: 0x1502544
	public static bool SmartIncircle(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc, TriangulationPoint pd) { }

	// RVA: 0x1501654
	public static bool InScanArea(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc, TriangulationPoint pd) { }

	// RVA: 0x14FECA0
	public static Orientation Orient2d(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc) { }

	// RVA: 0x1503BA0
	private static void .cctor() { }

}

// Namespace: 
private sealed class <Enumerate>d__10
{
	// Fields
	private int <>1__state; // 0x0
	private T <>2__current; // 0x0
	private int <>l__initialThreadId; // 0x0
	public UnityEngine.ProBuilder.Poly2Tri.FixedArray3<T> <>4__this; // 0x0
	public UnityEngine.ProBuilder.Poly2Tri.FixedArray3<T> <>3__<>4__this; // 0x0
	private int <i>5__2; // 0x0

	// Methods

	// RVA: 0x30D4A04
	public void .ctor(int <>1__state) { }

	// RVA: 0x30D488C
	private void System.IDisposable.Dispose() { }

	// RVA: 0x30D3738
	private bool MoveNext() { }

	// RVA: 0x318DB98
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }

	// RVA: 0x30D488C
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x30D3CF0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x30D3CF0
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal struct FixedArray3<T0>
{
	// Fields
	public T _0; // 0x0
	public T _1; // 0x0
	public T _2; // 0x0

	// Methods

	// RVA: 0x318DB98
	public T get_Item(int index) { }

	// RVA: 0x318DB98
	public void set_Item(int index, T value) { }

	// RVA: 0x318DB98
	public bool Contains(T value) { }

	// RVA: 0x318DB98
	public int IndexOf(T value) { }

	// RVA: 0x30D488C
	public void Clear() { }

	// RVA: 0x30D3CF0
	private System.Collections.Generic.IEnumerable<T> Enumerate() { }

	// RVA: 0x30D3CF0
	public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }

	// RVA: 0x30D3CF0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: 
private sealed class <Enumerate>d__10
{
	// Fields
	private int <>1__state; // 0x10
	private bool <>2__current; // 0x14
	private int <>l__initialThreadId; // 0x18
	public FixedBitArray3 <>4__this; // 0x1C
	public FixedBitArray3 <>3__<>4__this; // 0x1F
	private int <i>5__2; // 0x24

	// Methods

	// RVA: 0x1503C84
	public void .ctor(int <>1__state) { }

	// RVA: 0x1503DD4
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1503DD8
	private bool MoveNext() { }

	// RVA: 0x1503EA4
	private bool System.Collections.Generic.IEnumerator<System.Boolean>.get_Current() { }

	// RVA: 0x1503EAC
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1503EEC
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1503F54
	private System.Collections.Generic.IEnumerator<System.Boolean> System.Collections.Generic.IEnumerable<System.Boolean>.GetEnumerator() { }

	// RVA: 0x1503FFC
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal struct FixedBitArray3
{
	// Fields
	public bool _0; // 0x10
	public bool _1; // 0x11
	public bool _2; // 0x12

	// Methods

	// RVA: 0x14FBE70
	public bool get_Item(int index) { }

	// RVA: 0x14FBC60
	public void set_Item(int index, bool value) { }

	// RVA: 0x1501F50
	public void Clear() { }

	// RVA: 0x1503BFC
	private System.Collections.Generic.IEnumerable<System.Boolean> Enumerate() { }

	// RVA: 0x1503CBC
	public System.Collections.Generic.IEnumerator<System.Boolean> GetEnumerator() { }

	// RVA: 0x1503DD0
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}


