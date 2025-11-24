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

	// RVA: 0x153D238
	public void .ctor(System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.PolygonPoint> points) { }

	// RVA: 0x153D620
	public void .ctor(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Poly2Tri.PolygonPoint> points) { }

	// RVA: 0x153D6D4
	public TriangulationMode get_TriangulationMode() { }

	// RVA: 0x153D6DC
	public void AddHole(Polygon poly) { }

	// RVA: 0x153D794
	public System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> get_Triangles() { }

	// RVA: 0x153D79C
	public void AddTriangle(DelaunayTriangle t) { }

	// RVA: 0x153D800
	public void AddTriangles(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> list) { }

	// RVA: 0x153D864
	public void Prepare(TriangulationContext tcx) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class PolygonPoint
{
	// Methods

	// RVA: 0x153DD84
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

	// RVA: 0x153DE04
	public bool get_IsInterior() { }

	// RVA: 0x153DE0C
	public void set_IsInterior(bool value) { }

	// RVA: 0x153DE14
	public void .ctor(TriangulationPoint p1, TriangulationPoint p2, TriangulationPoint p3) { }

	// RVA: 0x153DEBC
	public int IndexOf(TriangulationPoint p) { }

	// RVA: 0x153DF6C
	public int IndexCCWFrom(TriangulationPoint p) { }

	// RVA: 0x153DFA4
	public bool Contains(TriangulationPoint p) { }

	// RVA: 0x153E000
	private void MarkNeighbor(TriangulationPoint p1, TriangulationPoint p2, DelaunayTriangle t) { }

	// RVA: 0x153E248
	public void MarkNeighbor(DelaunayTriangle t) { }

	// RVA: 0x153E478
	public TriangulationPoint OppositePoint(DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0x153E604
	public DelaunayTriangle NeighborCWFrom(TriangulationPoint point) { }

	// RVA: 0x153E6B0
	public DelaunayTriangle NeighborCCWFrom(TriangulationPoint point) { }

	// RVA: 0x153E75C
	public DelaunayTriangle NeighborAcrossFrom(TriangulationPoint point) { }

	// RVA: 0x153E7E8
	public TriangulationPoint PointCCWFrom(TriangulationPoint point) { }

	// RVA: 0x153E578
	public TriangulationPoint PointCWFrom(TriangulationPoint point) { }

	// RVA: 0x153E874
	private void RotateCW() { }

	// RVA: 0x153E944
	public void Legalize(TriangulationPoint oPoint, TriangulationPoint nPoint) { }

	// RVA: 0x153E9E8
	public override string ToString() { }

	// RVA: 0x153EBA8
	public void MarkConstrainedEdge(int index) { }

	// RVA: 0x153ECBC
	public void MarkConstrainedEdge(TriangulationPoint p, TriangulationPoint q) { }

	// RVA: 0x153E154
	public int EdgeIndex(TriangulationPoint p1, TriangulationPoint p2) { }

	// RVA: 0x153ED98
	public bool GetConstrainedEdgeCCW(TriangulationPoint p) { }

	// RVA: 0x153EED0
	public bool GetConstrainedEdgeCW(TriangulationPoint p) { }

	// RVA: 0x153EF8C
	public void SetConstrainedEdgeCCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x153F04C
	public void SetConstrainedEdgeCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x153F10C
	public bool GetDelaunayEdgeCCW(TriangulationPoint p) { }

	// RVA: 0x153F1C8
	public bool GetDelaunayEdgeCW(TriangulationPoint p) { }

	// RVA: 0x153F284
	public void SetDelaunayEdgeCCW(TriangulationPoint p, bool ce) { }

	// RVA: 0x153F344
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

	// RVA: 0x153F404
	public void .ctor(AdvancingFrontNode head, AdvancingFrontNode tail) { }

	// RVA: 0x153F464
	public void AddNode(AdvancingFrontNode node) { }

	// RVA: 0x153F468
	public void RemoveNode(AdvancingFrontNode node) { }

	// RVA: 0x153F46C
	public override string ToString() { }

	// RVA: 0x153F568
	private AdvancingFrontNode FindSearchNode(Double x) { }

	// RVA: 0x153F570
	public AdvancingFrontNode LocateNode(TriangulationPoint point) { }

	// RVA: 0x153F600
	private AdvancingFrontNode LocateNode(Double x) { }

	// RVA: 0x153F688
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

	// RVA: 0x153F78C
	public void .ctor(TriangulationPoint point) { }

	// RVA: 0x153F7D4
	public bool get_HasNext() { }

	// RVA: 0x153F7E4
	public bool get_HasPrev() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal static class DTSweep
{
	// Methods

	// RVA: 0x153F7F4
	public static void Triangulate(DTSweepContext tcx) { }

	// RVA: 0x153FB8C
	private static void Sweep(DTSweepContext tcx) { }

	// RVA: 0x1540050
	private static void FinalizationConvexHull(DTSweepContext tcx) { }

	// RVA: 0x1540C44
	private static void TurnAdvancingFrontConvex(DTSweepContext tcx, AdvancingFrontNode b, AdvancingFrontNode c) { }

	// RVA: 0x153FEBC
	private static void FinalizationPolygon(DTSweepContext tcx) { }

	// RVA: 0x15406FC
	private static AdvancingFrontNode PointEvent(DTSweepContext tcx, TriangulationPoint point) { }

	// RVA: 0x1541FF0
	private static AdvancingFrontNode NewFrontTriangle(DTSweepContext tcx, TriangulationPoint point, AdvancingFrontNode node) { }

	// RVA: 0x15409AC
	private static void EdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x1542A94
	private static void FillEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x1543228
	private static void FillRightConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x154338C
	private static void FillRightConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x154353C
	private static void FillRightBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x1542E7C
	private static void FillRightAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x15437E4
	private static void FillLeftConvexEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x1543988
	private static void FillLeftConcaveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x1543AE4
	private static void FillLeftBelowEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x1543054
	private static void FillLeftAboveEdgeEvent(DTSweepContext tcx, DTSweepConstraint edge, AdvancingFrontNode node) { }

	// RVA: 0x15428B0
	private static bool IsEdgeSideOfTriangle(DelaunayTriangle triangle, TriangulationPoint ep, TriangulationPoint eq) { }

	// RVA: 0x1542AC4
	private static void EdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle triangle, TriangulationPoint point) { }

	// RVA: 0x1543DEC
	private static void FlipEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0x15448B4
	private static TriangulationPoint NextFlipPoint(TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle ot, TriangulationPoint op) { }

	// RVA: 0x15446B8
	private static DelaunayTriangle NextFlipTriangle(DTSweepContext tcx, Orientation o, DelaunayTriangle t, DelaunayTriangle ot, TriangulationPoint p, TriangulationPoint op) { }

	// RVA: 0x1544A90
	private static void FlipScanEdgeEvent(DTSweepContext tcx, TriangulationPoint ep, TriangulationPoint eq, DelaunayTriangle flipTriangle, DelaunayTriangle t, TriangulationPoint p) { }

	// RVA: 0x15422A8
	private static void FillAdvancingFront(DTSweepContext tcx, AdvancingFrontNode n) { }

	// RVA: 0x15450AC
	private static void FillBasin(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x15452C0
	private static void FillBasinReq(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x154549C
	private static bool IsShallow(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x1544F40
	private static Double HoleAngle(AdvancingFrontNode node) { }

	// RVA: 0x1545010
	private static Double BasinAngle(AdvancingFrontNode node) { }

	// RVA: 0x1541DA0
	private static void Fill(DTSweepContext tcx, AdvancingFrontNode node) { }

	// RVA: 0x15423B0
	private static bool Legalize(DTSweepContext tcx, DelaunayTriangle t) { }

	// RVA: 0x1540E48
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

	// RVA: 0x15455F4
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepConstraint
{
	// Methods

	// RVA: 0x15455FC
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

	// RVA: 0x154577C
	public TriangulationPoint get_Head() { }

	// RVA: 0x1545784
	public void set_Head(TriangulationPoint value) { }

	// RVA: 0x154578C
	public TriangulationPoint get_Tail() { }

	// RVA: 0x1545794
	public void set_Tail(TriangulationPoint value) { }

	// RVA: 0x154579C
	public void .ctor() { }

	// RVA: 0x1545994
	public override bool get_IsDebugEnabled() { }

	// RVA: 0x1541A7C
	public void RemoveFromList(DelaunayTriangle triangle) { }

	// RVA: 0x1541F54
	public void MeshClean(DelaunayTriangle triangle) { }

	// RVA: 0x154599C
	private void MeshCleanReq(DelaunayTriangle triangle) { }

	// RVA: 0x1545B0C
	public override void Clear() { }

	// RVA: 0x154228C
	public void AddNode(AdvancingFrontNode node) { }

	// RVA: 0x154550C
	public void RemoveNode(AdvancingFrontNode node) { }

	// RVA: 0x1541F58
	public AdvancingFrontNode LocateNode(TriangulationPoint point) { }

	// RVA: 0x153F860
	public void CreateAdvancingFront() { }

	// RVA: 0x15417D0
	public void MapTriangleToNodes(DelaunayTriangle t) { }

	// RVA: 0x1545C68
	public override void PrepareTriangulation(Triangulatable t) { }

	// RVA: 0x1541AE0
	public void FinalizeTriangulation() { }

	// RVA: 0x15460C8
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

	// RVA: 0x154284C
	public void set_PrimaryTriangle(DelaunayTriangle value) { }

	// RVA: 0x15445D4
	public void set_SecondaryTriangle(DelaunayTriangle value) { }

	// RVA: 0x1546134
	public void set_ActivePoint(TriangulationPoint value) { }

	// RVA: 0x1541C20
	public void set_ActiveNode(AdvancingFrontNode value) { }

	// RVA: 0x1540948
	public void set_ActiveConstraint(DTSweepConstraint value) { }

	// RVA: 0x1546198
	public override void Clear() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepEdgeEvent
{
	// Fields
	public DTSweepConstraint ConstrainedEdge; // 0x10
	public bool Right; // 0x18

	// Methods

	// RVA: 0x15458A4
	public void .ctor() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class DTSweepPointComparator
{
	// Methods

	// RVA: 0x15462E0
	public int Compare(TriangulationPoint p1, TriangulationPoint p2) { }

	// RVA: 0x15458AC
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

	// RVA: 0x1543D88
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

	// RVA: 0x154634C
	public System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> get_Points() { }

	// RVA: 0x1546354
	private void set_Points(System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> value) { }

	// RVA: 0x154635C
	public System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> get_Triangles() { }

	// RVA: 0x1546364
	private void set_Triangles(System.Collections.Generic.IList<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> value) { }

	// RVA: 0x154636C
	public void .ctor(System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.TriangulationPoint> points) { }

	// RVA: 0x1546408
	public virtual TriangulationMode get_TriangulationMode() { }

	// RVA: 0x1546410
	public void AddTriangle(DelaunayTriangle t) { }

	// RVA: 0x15464C8
	public void AddTriangles(System.Collections.Generic.IEnumerable<UnityEngine.ProBuilder.Poly2Tri.DelaunayTriangle> list) { }

	// RVA: 0x154680C
	public virtual void Prepare(TriangulationContext tcx) { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class TriangulationConstraint
{
	// Fields
	public TriangulationPoint P; // 0x10
	public TriangulationPoint Q; // 0x18

	// Methods

	// RVA: 0x15456BC
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

	// RVA: 0x15469D8
	public TriangulationDebugContext get_DebugContext() { }

	// RVA: 0x15469E0
	public TriangulationMode get_TriangulationMode() { }

	// RVA: 0x15469E8
	protected void set_TriangulationMode(TriangulationMode value) { }

	// RVA: 0x15469F0
	public Triangulatable get_Triangulatable() { }

	// RVA: 0x15469F8
	private void set_Triangulatable(Triangulatable value) { }

	// RVA: 0x1546A00
	public int get_StepCount() { }

	// RVA: 0x1546A08
	private void set_StepCount(int value) { }

	// RVA: 0x15406EC
	public void Done() { }

	// RVA: 0x1545FA8
	public virtual void PrepareTriangulation(Triangulatable t) { }

	// RVA: -1
	public abstract TriangulationConstraint NewConstraint(TriangulationPoint a, TriangulationPoint b) { }

	// RVA: 0x1540C40
	public void Update(string message) { }

	// RVA: 0x1545BB4
	public virtual void Clear() { }

	// RVA: 0x1546A10
	public virtual bool get_IsDebugEnabled() { }

	// RVA: 0x15408C0
	public DTSweepDebugContext get_DTDebugContext() { }

	// RVA: 0x15458B4
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

	// RVA: 0x1546A18
	public System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.DTSweepConstraint> get_Edges() { }

	// RVA: 0x1546A20
	private void set_Edges(System.Collections.Generic.List<UnityEngine.ProBuilder.Poly2Tri.DTSweepConstraint> value) { }

	// RVA: 0x153DDC4
	public void .ctor(Double x, Double y, int index) { }

	// RVA: 0x1546A28
	public override string ToString() { }

	// RVA: 0x15456C4
	public void AddEdge(DTSweepConstraint e) { }

	// RVA: 0x15408B0
	public bool get_HasEdges() { }

}

// Namespace: UnityEngine.ProBuilder.Poly2Tri
internal class TriangulationUtil
{
	// Fields
	public static Double EPSILON; // 0x0

	// Methods

	// RVA: 0x1545528
	public static bool SmartIncircle(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc, TriangulationPoint pd) { }

	// RVA: 0x1544638
	public static bool InScanArea(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc, TriangulationPoint pd) { }

	// RVA: 0x1541C84
	public static Orientation Orient2d(TriangulationPoint pa, TriangulationPoint pb, TriangulationPoint pc) { }

	// RVA: 0x1546B84
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

	// RVA: 0x3526518
	public void .ctor(int <>1__state) { }

	// RVA: 0x35263A0
	private void System.IDisposable.Dispose() { }

	// RVA: 0x35251DC
	private bool MoveNext() { }

	// RVA: 0x26AD93C
	private T System.Collections.Generic.IEnumerator<T>.get_Current() { }

	// RVA: 0x35263A0
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x3525804
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x3525804
	private System.Collections.Generic.IEnumerator<T> System.Collections.Generic.IEnumerable<T>.GetEnumerator() { }

	// RVA: 0x3525804
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

	// RVA: 0x26AD93C
	public T get_Item(int index) { }

	// RVA: 0x26AD93C
	public void set_Item(int index, T value) { }

	// RVA: 0x26AD93C
	public bool Contains(T value) { }

	// RVA: 0x26AD93C
	public int IndexOf(T value) { }

	// RVA: 0x35263A0
	public void Clear() { }

	// RVA: 0x3525804
	private System.Collections.Generic.IEnumerable<T> Enumerate() { }

	// RVA: 0x3525804
	public System.Collections.Generic.IEnumerator<T> GetEnumerator() { }

	// RVA: 0x3525804
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

	// RVA: 0x1546C68
	public void .ctor(int <>1__state) { }

	// RVA: 0x1546DB8
	private void System.IDisposable.Dispose() { }

	// RVA: 0x1546DBC
	private bool MoveNext() { }

	// RVA: 0x1546E88
	private bool System.Collections.Generic.IEnumerator<System.Boolean>.get_Current() { }

	// RVA: 0x1546E90
	private void System.Collections.IEnumerator.Reset() { }

	// RVA: 0x1546ED0
	private object System.Collections.IEnumerator.get_Current() { }

	// RVA: 0x1546F04
	private System.Collections.Generic.IEnumerator<System.Boolean> System.Collections.Generic.IEnumerable<System.Boolean>.GetEnumerator() { }

	// RVA: 0x1546FAC
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

	// RVA: 0x153EE54
	public bool get_Item(int index) { }

	// RVA: 0x153EC44
	public void set_Item(int index, bool value) { }

	// RVA: 0x1544F34
	public void Clear() { }

	// RVA: 0x1546BE0
	private System.Collections.Generic.IEnumerable<System.Boolean> Enumerate() { }

	// RVA: 0x1546CA0
	public System.Collections.Generic.IEnumerator<System.Boolean> GetEnumerator() { }

	// RVA: 0x1546DB4
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}


