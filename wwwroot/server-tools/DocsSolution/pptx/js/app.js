"use strict";

let myFile = null;
const dataTransfer = new DataTransfer();
let sourceFile = Metro.storage.getItem("OpenPowerPointFile", null);
setTimeout(function () { $("body > label > span.button")[0].style["display"] = "none"; }, 100);

function GetFile(e) {
    fetch(sourceFile).then(r => r.blob()).then(data => {
        myFile = new File([data], sourceFile);
        dataTransfer.items.add(myFile);
        App.load(dataTransfer.files[0]);
    });
}

const Utils = {
    parseXml: (xmlStr) => new DOMParser().parseFromString(xmlStr, "application/xml"),
    emuToPx: (emu) => Math.round(Number(emu) / 9525),

    
    applyLum: (hex, lumMod, lumOff) => {
        if (!hex || !hex.startsWith("#")) return hex;
        let r = parseInt(hex.substring(1, 3), 16);
        let g = parseInt(hex.substring(3, 5), 16);
        let b = parseInt(hex.substring(5, 7), 16);

        const mod = (lumMod !== undefined) ? parseInt(lumMod, 10) / 100000 : 1;
        const off = (lumOff !== undefined) ? parseInt(lumOff, 10) / 100000 : 0;

        const transform = (c) => Math.min(255, Math.max(0, Math.round(c * mod + (255 * off))));

        return "#" + ((1 << 24) + (transform(r) << 16) + (transform(g) << 8) + transform(b)).toString(16).slice(1);
    },

    find: (node, localName) => {
        if (!node || !node.children) return null;
        for (let i = 0; i < node.children.length; i++) if (node.children[i].localName === localName) return node.children[i];
        return null;
    },
    findAll: (node, localName) => {
        if (!node) return [];
        const res = [];
        const all = node.getElementsByTagName("*");
        for (let i = 0; i < all.length; i++) if (all[i].localName === localName) res.push(all[i]);
        return res;
    },
    getFile: (zip, path) => {
        let p = path.replace(/\\/g, "/").replace(/^\//, "");
        if (zip.files[p]) return zip.files[p];
        const lower = p.toLowerCase();
        for (const f in zip.files) if (f.toLowerCase() === lower) return zip.files[f];
        return null;
    },
    b64: (u8) => {
        let b = ''; const len = u8.byteLength;
        for (let i = 0; i < len; i++) b += String.fromCharCode(u8[i]);
        return window.btoa(b);
    },


    validatePptxFile: (file) => {
        const MAX_FILE_SIZE = 200 * 1024 * 1024; // 200MB

        if (!file) return { valid: false, error: "ă•ă‚ˇă‚¤ă«ăŚé¸ćŠžă•ă‚Śă¦ă„ăľă›ă‚“ă€‚" };
        if (file.size > MAX_FILE_SIZE) return { valid: false, error: "ă•ă‚ˇă‚¤ă«ă‚µă‚¤ă‚şăŚĺ¤§ăŤă™ăŽăľă™ďĽä¸Šé™: 200MBďĽ‰ă€‚" };
        if (!file.name.toLowerCase().endsWith(".pptx")) return { valid: false, error: "PPTXă•ă‚ˇă‚¤ă«ă®ăżĺŻľĺżśă—ă¦ă„ăľă™ă€‚" };
        return { valid: true };
    }
};

/**
 * PPTX Parser Logic
 */
class PptxParser {
    constructor() {
        this.zip = null;
        this.slideSize = { width: 960, height: 540 };
        this.slides = [];
        this.themeColors = {};
    }

    async load(file) {
        this.zip = await JSZip.loadAsync(file);
        await this.parseTheme();

        const presXml = await this.readXml("ppt/presentation.xml");
        if (presXml) {
            const sldSz = Utils.findAll(presXml.documentElement, "sldSz")[0];
            if (sldSz) {
                this.slideSize.width = Utils.emuToPx(sldSz.getAttribute("cx"));
                this.slideSize.height = Utils.emuToPx(sldSz.getAttribute("cy"));
            }
        }

        const files = Object.keys(this.zip.files);
        this.slides = files.filter(f => /^ppt\/slides\/slide\d+\.xml$/i.test(f))
            .sort((a, b) => {
                const getNum = s => parseInt(s.match(/slide(\d+)\.xml/i)[1], 10);
                return getNum(a) - getNum(b);
            });

        return this.slides.length;
    }

    async readXml(path) {
        const file = Utils.getFile(this.zip, path);
        if (!file) return null;
        return Utils.parseXml(await file.async("text"));
    }

    async parseTheme() {
        const themeFile = Object.keys(this.zip.files).find(f => /^ppt\/theme\/theme\d+\.xml$/i.test(f));
        if (!themeFile) return;
        const xml = await this.readXml(themeFile);
        if (!xml) return;

        const clrScheme = Utils.findAll(xml.documentElement, "clrScheme")[0];
        if (clrScheme) {
            for (let i = 0; i < clrScheme.children.length; i++) {
                const node = clrScheme.children[i];
                const srgb = Utils.find(node, "srgbClr");
                const sys = Utils.find(node, "sysClr");
                if (srgb) this.themeColors[node.localName] = "#" + srgb.getAttribute("val");
                else if (sys) this.themeColors[node.localName] = "#" + sys.getAttribute("lastClr");
            }
        }
    }

    async getSlideData(index) {
        if (index < 0 || index >= this.slides.length) return null;

        const slidePath = this.slides[index];
        const slideXml = await this.readXml(slidePath);
        const slideRels = await this.loadRels(slidePath);
        const hierarchy = await this.resolveHierarchy(slidePath, slideRels);
        const background = await this.resolveBackground(hierarchy);

        this._supplementaryTexts = [];
        let allShapes = [];
        // Master -> Layout -> Slide order
        if (hierarchy[2]) {
            const mShapes = await this.extractShapes(hierarchy[2].xml, hierarchy[2].rels, hierarchy[2].path);
            this.masterPlaceholders = mShapes.filter(s => s.isPlaceholder);
            allShapes = allShapes.concat(mShapes.filter(s => !s.isPlaceholder));
        } else {
            this.masterPlaceholders = [];
        }
        if (hierarchy[1]) {
            const lShapes = await this.extractShapes(hierarchy[1].xml, hierarchy[1].rels, hierarchy[1].path);
            this.layoutPlaceholders = lShapes.filter(s => s.isPlaceholder);
            allShapes = allShapes.concat(lShapes.filter(s => !s.isPlaceholder));
        } else {
            this.layoutPlaceholders = [];
        }

        const slideShapes = await this.extractShapes(slideXml, slideRels, slidePath);
        slideShapes.forEach(shape => {
            if (shape.isPlaceholder && (!shape.box || (shape.box.w === 0 && shape.box.h === 0))) {
                let ph = this.matchPlaceholder(shape, this.layoutPlaceholders);
                if (!ph || !ph.box || (ph.box.w === 0 && ph.box.h === 0)) {
                    const masterPh = this.matchPlaceholder(shape, this.masterPlaceholders);
                    if (masterPh && masterPh.box && (masterPh.box.w > 0 || masterPh.box.h > 0)) ph = masterPh;
                }
                if (ph && ph.box) shape.box = { ...ph.box };
            }
        });

        // Include shapes with text even if zero-size (rescue)
        allShapes = allShapes.concat(slideShapes.filter(s => {
            if (!s.box) return false;
            if (s.box.w > 0) return true;
            if (s.paragraphs && s.paragraphs.some(p => p.runs.some(r => r.text && r.text.trim()))) return true;
            return false;
        }));

        return { size: this.slideSize, background, shapes: allShapes, supplementaryTexts: this._supplementaryTexts };
    }

    matchPlaceholder(slideShape, placeholders) {
        if (slideShape.phIdx != null) {
            const match = placeholders.find(p => p.phIdx === slideShape.phIdx);
            if (match) return match;
        }
        if (slideShape.phType != null) {
            const match = placeholders.find(p => p.phType === slideShape.phType);
            if (match) return match;
        }
        return null;
    }

    async extractShapes(xml, rels, sourcePath) {
        const shapes = [];
        const spTree = Utils.findAll(xml.documentElement, "spTree")[0];
        if (spTree) await this.traverse(spTree, rels, sourcePath, shapes, (box) => box);
        return shapes;
    }

    async traverse(node, rels, sourcePath, list, transform) {
        if (!node || !node.children) return;

        for (let i = 0; i < node.children.length; i++) {
            const child = node.children[i];
            const name = child.localName;

            if (name === "grpSp") await this.processGroup(child, rels, sourcePath, list, transform);
            else if (name === "AlternateContent") {
                const choice = Utils.find(child, "Choice");
                if (choice) await this.traverse(choice, rels, sourcePath, list, transform);
                else {
                    const fb = Utils.find(child, "Fallback");
                    if (fb) await this.traverse(fb, rels, sourcePath, list, transform);
                }
            }
            else if (["sp", "pic", "graphicFrame"].includes(name)) {
                // Table detection inside graphicFrame
                let isTable = false;
                let graphicData = null;
                if (name === "graphicFrame") {
                    const graphic = Utils.find(child, "graphic");
                    graphicData = graphic ? Utils.find(graphic, "graphicData") : null;
                    if (graphicData && Utils.find(graphicData, "tbl")) isTable = true;
                }

                if (isTable) {
                    const tableShape = await this.parseTable(child, rels, sourcePath);
                    if (tableShape) {
                        tableShape.box = transform(tableShape.box);
                        list.push(tableShape);
                    }
                } else {
                    const shape = await this.parseShape(child, rels, sourcePath, name);
                    if (shape) {
                        shape.box = transform(shape.box);
                        list.push(shape);
                    }
                    // Extract SmartArt/Chart external text
                    if (name === "graphicFrame" && graphicData && this._supplementaryTexts) {
                        const exTexts = await this.extractExternalText(graphicData, rels, sourcePath);
                        if (exTexts.length > 0) {
                            const uri = graphicData.getAttribute("uri") || "";
                            const source = uri.includes("diagram") ? "SmartArt" : uri.includes("chart") ? "Chart" : "Graphic";
                            this._supplementaryTexts.push({ source, texts: exTexts });
                        }
                    }
                }
            }
        }
    }

    // --- Table Parsing ---
    async parseTable(node, rels, sourcePath) {
        const xfrm = Utils.find(node, "xfrm");
        if (!xfrm) return null;

        const off = Utils.find(xfrm, "off");
        const ext = Utils.find(xfrm, "ext");
        if (!off || !ext) return null;

        const box = {
            x: Utils.emuToPx(off.getAttribute("x")),
            y: Utils.emuToPx(off.getAttribute("y")),
            w: Utils.emuToPx(ext.getAttribute("cx")),
            h: Utils.emuToPx(ext.getAttribute("cy"))
        };

        const graphic = Utils.find(node, "graphic");
        const graphicData = Utils.find(graphic, "graphicData");
        const tbl = Utils.find(graphicData, "tbl");

        // Columns
        const tblGrid = Utils.find(tbl, "tblGrid");
        const cols = [];
        if (tblGrid) {
            const gridCols = Utils.findAll(tblGrid, "gridCol");
            gridCols.forEach(c => cols.push(Utils.emuToPx(c.getAttribute("w"))));
        }

        // Rows & Cells
        const rows = [];
        const trs = Utils.findAll(tbl, "tr");
        for (const tr of trs) {
            const rowH = Utils.emuToPx(tr.getAttribute("h"));
            const cells = [];
            const tcs = Utils.findAll(tr, "tc");

            for (const tc of tcs) {
                const rowSpan = parseInt(tc.getAttribute("rowSpan") || "1", 10);
                const gridSpan = parseInt(tc.getAttribute("gridSpan") || "1", 10);

                // Cell Background
                let cellBg = null;
                const tcPr = Utils.find(tc, "tcPr");
                if (tcPr) {
                    const solidFill = Utils.find(tcPr, "solidFill");
                    if (solidFill) cellBg = this.extractColor(solidFill);
                }

                // Cell Text
                const textData = this.parseTxBody(Utils.find(tc, "txBody"), rels);

                cells.push({
                    rowSpan, colSpan: gridSpan,
                    bgColor: cellBg,
                    text: textData
                });
            }
            rows.push({ height: rowH, cells });
        }

        return { type: 'table', box, cols, rows };
    }

    // --- Common Text Parsing (Used for Shapes and Tables) ---
    parseTxBody(txBodyNode, rels) {
        if (!txBodyNode) return null;

        let vAlign = "top";
        let pad = { l: 5, t: 5, r: 5, b: 5 };
        const bodyPr = Utils.find(txBodyNode, "bodyPr");
        if (bodyPr) {
            const anchor = bodyPr.getAttribute("anchor");
            if (anchor === "ctr") vAlign = "center";
            else if (anchor === "b") vAlign = "bottom";
            if (bodyPr.getAttribute("lIns")) pad.l = Utils.emuToPx(bodyPr.getAttribute("lIns"));
            if (bodyPr.getAttribute("tIns")) pad.t = Utils.emuToPx(bodyPr.getAttribute("tIns"));
        }

        const paragraphs = [];
        const paras = Utils.findAll(txBodyNode, "p");

        for (const p of paras) {
            const pPr = Utils.find(p, "pPr");
            let align = "left";
            let marL = 0, indent = 0;

            if (pPr) {
                const algn = pPr.getAttribute("algn");
                if (algn === "ctr") align = "center";
                if (algn === "r") align = "right";
                if (algn === "j") align = "justify";
                if (pPr.getAttribute("marL")) marL = Utils.emuToPx(pPr.getAttribute("marL"));
                if (pPr.getAttribute("indent")) indent = Utils.emuToPx(pPr.getAttribute("indent"));
            }

            const runs = [];
            this.collectRunsFromNode(p, runs, rels);
            if (runs.length === 0) runs.push({ text: "\u00A0", style: {} });
            paragraphs.push({ align, marL, indent, runs });
        }

        return { vAlign, pad, paragraphs };
    }

    // --- Collect runs from paragraph children (handles <a:r>, <a:br>, <a:fld>, AlternateContent) ---
    collectRunsFromNode(node, runs, rels) {
        for (let i = 0; i < node.children.length; i++) {
            const child = node.children[i];
            const cName = child.localName;
            if (cName === "r" || cName === "fld") {
                this.parseRunNode(child, runs, rels);
            } else if (cName === "br") {
                runs.push({ text: "\n", style: {} });
            } else if (cName === "AlternateContent") {
                const choice = Utils.find(child, "Choice");
                const target = choice || Utils.find(child, "Fallback");
                if (target) this.collectRunsFromNode(target, runs, rels);
            }
        }
    }

    parseRunNode(node, runs, rels) {
        const tNode = Utils.find(node, "t");
        if (!tNode) return;
        const rPr = Utils.find(node, "rPr");
        const style = {};
        if (rPr) {
            const sz = rPr.getAttribute("sz");
            if (sz) style.fontSize = (parseInt(sz, 10) / 100) + "pt";
            if (rPr.getAttribute("b") === "1") style.fontWeight = "bold";
            if (rPr.getAttribute("i") === "1") style.fontStyle = "italic";
            const fill = Utils.find(rPr, "solidFill");
            if (fill) {
                const c = this.extractColor(fill);
                if (c) style.color = c;
            }
        }
        if (!style.color) style.color = "#000000";
        let link = null;
        if (rPr && rels && rels._hyperlinks) {
            const hlinkClick = Utils.find(rPr, "hlinkClick");
            if (hlinkClick) {
                const rId = hlinkClick.getAttribute("r:id");
                if (rId && rels._hyperlinks[rId]) link = rels._hyperlinks[rId];
            }
        }
        runs.push({ text: tNode.textContent, style, link });
    }

    async processGroup(node, rels, sourcePath, list, parentTransform) {
        const grpSpPr = Utils.find(node, "grpSpPr");
        const xfrm = grpSpPr ? Utils.find(grpSpPr, "xfrm") : null;
        let myTransform = parentTransform;

        if (xfrm) {
            const off = Utils.find(xfrm, "off");
            const ext = Utils.find(xfrm, "ext");
            const chOff = Utils.find(xfrm, "chOff");
            const chExt = Utils.find(xfrm, "chExt");

            if (off && ext && chOff && chExt) {
                const grpRect = {
                    x: Utils.emuToPx(off.getAttribute("x")),
                    y: Utils.emuToPx(off.getAttribute("y")),
                    w: Utils.emuToPx(ext.getAttribute("cx")),
                    h: Utils.emuToPx(ext.getAttribute("cy"))
                };
                const chRect = {
                    x: Utils.emuToPx(chOff.getAttribute("x")),
                    y: Utils.emuToPx(chOff.getAttribute("y")),
                    w: Utils.emuToPx(chExt.getAttribute("cx")),
                    h: Utils.emuToPx(chExt.getAttribute("cy"))
                };

                myTransform = (box) => {
                    if (chRect.w === 0 || chRect.h === 0) return parentTransform(box);
                    const sx = grpRect.w / chRect.w;
                    const sy = grpRect.h / chRect.h;
                    return parentTransform({
                        x: grpRect.x + (box.x - chRect.x) * sx,
                        y: grpRect.y + (box.y - chRect.y) * sy,
                        w: box.w * sx,
                        h: box.h * sy
                    });
                };
            }
        }
        await this.traverse(node, rels, sourcePath, list, myTransform);
    }

    async parseShape(node, rels, sourcePath, type) {
        let xfrm = null, spPr = null;
        if (type === "graphicFrame") xfrm = Utils.find(node, "xfrm");
        else {
            spPr = Utils.find(node, "spPr");
            if (spPr) xfrm = Utils.find(spPr, "xfrm");
        }

        let isPlaceholder = false;
        let phType = undefined, phIdx = undefined;
        const nvPr = Utils.find(Utils.find(node, "nvSpPr") || Utils.find(node, "nvPicPr"), "nvPr");
        if (nvPr) {
            const ph = Utils.find(nvPr, "ph");
            if (ph) {
                isPlaceholder = true;
                phType = ph.getAttribute("type");
                phIdx = ph.getAttribute("idx");
            }
        }

        let box = { x: 0, y: 0, w: 0, h: 0 };
        if (xfrm) {
            const off = Utils.find(xfrm, "off");
            const ext = Utils.find(xfrm, "ext");
            if (off && ext) {
                box = {
                    x: Utils.emuToPx(off.getAttribute("x")),
                    y: Utils.emuToPx(off.getAttribute("y")),
                    w: Utils.emuToPx(ext.getAttribute("cx")),
                    h: Utils.emuToPx(ext.getAttribute("cy"))
                };
                const rot = xfrm.getAttribute("rot");
                if (rot) box.rot = parseInt(rot, 10) / 60000;
            }
        }

        if (type === "pic") {
            const blipFill = Utils.find(node, "blipFill");
            const blip = blipFill ? Utils.find(blipFill, "blip") : null;
            const embed = blip?.getAttribute("r:embed");
            if (embed && rels[embed]) {
                const imgPath = this.resolvePath(sourcePath, rels[embed]);
                const src = await this.loadImage(imgPath);
                if (src) return { type: 'image', box, src, isPlaceholder, phType, phIdx };
            }
        }

        let bgColor = null;
        if (type === "sp" && spPr) {
            const solidFill = Utils.find(spPr, "solidFill");
            if (solidFill) bgColor = this.extractColor(solidFill);
            else {
                const style = Utils.find(node, "style");
                if (style) {
                    const fillRef = Utils.find(style, "fillRef");
                    if (fillRef) bgColor = this.extractColor(fillRef);
                }
            }
        }

        const txBody = Utils.findAll(node, "txBody")[0];
        const textData = this.parseTxBody(txBody, rels);

        if (!textData && !bgColor) return { type: 'rect', box, isPlaceholder, phType, phIdx, visible: false };

        return {
            type: 'text', box, bgColor,
            vAlign: textData ? textData.vAlign : "top",
            pad: textData ? textData.pad : { l: 0, t: 0, r: 0, b: 0 },
            paragraphs: textData ? textData.paragraphs : [],
            isPlaceholder, phType, phIdx
        };
    }

    async loadRels(sourcePath) {
        const parts = sourcePath.split("/");
        const fileName = parts.pop();
        const dir = parts.join("/");
        const relsPath = `${dir}/_rels/${fileName}.rels`;
        const relsMap = {};
        const hyperlinks = {};
        const xml = await this.readXml(relsPath);
        if (xml) {
            const rels = Utils.findAll(xml.documentElement, "Relationship");
            for (const r of rels) {
                relsMap[r.getAttribute("Id")] = r.getAttribute("Target");
                if (r.getAttribute("TargetMode") === "External") {
                    hyperlinks[r.getAttribute("Id")] = r.getAttribute("Target");
                }
            }
        }
        Object.defineProperty(relsMap, '_hyperlinks', { value: hyperlinks, enumerable: false });
        return relsMap;
    }

    async resolveHierarchy(slidePath, slideRels) {
        const chain = [{ type: 'slide', path: slidePath, rels: slideRels, xml: await this.readXml(slidePath) }];

        let layoutPath = null;
        for (const k in slideRels) if (slideRels[k].includes("slideLayout")) layoutPath = this.resolvePath(slidePath, slideRels[k]);

        if (layoutPath) {
            const lXml = await this.readXml(layoutPath);
            const lRels = await this.loadRels(layoutPath);
            chain.push({ type: 'layout', path: layoutPath, rels: lRels, xml: lXml });

            let masterPath = null;
            for (const k in lRels) if (lRels[k].includes("slideMaster")) masterPath = this.resolvePath(layoutPath, lRels[k]);

            if (masterPath) {
                const mXml = await this.readXml(masterPath);
                const mRels = await this.loadRels(masterPath);
                chain.push({ type: 'master', path: masterPath, rels: mRels, xml: mXml });
            }
        }
        return chain;
    }

    resolvePath(base, target) {
        if (target.startsWith("/")) {
            return target.substring(1);
        }
        if (/^https?:\/\//i.test(target)) {
            return target;
        }
        const baseDir = base.substring(0, base.lastIndexOf("/"));
        const parts = baseDir.split("/").filter(p => p !== "");
        const tParts = target.split("/").filter(p => p !== "");
        for (const p of tParts) {
            if (p === "..") {
                if (parts.length > 0) parts.pop();
            }
            else if (p !== ".") parts.push(p);
        }
        return parts.join("/");
    }

    async resolveBackground(hierarchy) {
        for (const node of hierarchy) {
            if (!node.xml) continue;
            const bg = Utils.findAll(node.xml.documentElement, "bg")[0];
            if (bg) {
                const bgPr = Utils.find(bg, "bgPr");
                if (bgPr) {
                    const solid = Utils.find(bgPr, "solidFill");
                    if (solid) return { type: 'color', value: this.extractColor(solid) || "#fff" };
                    const blipFill = Utils.find(bgPr, "blipFill");
                    if (blipFill) {
                        const blip = Utils.find(blipFill, "blip");
                        const embed = blip?.getAttribute("r:embed");
                        if (embed && node.rels[embed]) {
                            const path = this.resolvePath(node.path, node.rels[embed]);
                            const img = await this.loadImage(path);
                            if (img) return { type: 'image', value: img };
                        }
                    }
                }
            }
        }
        return { type: 'color', value: '#ffffff' }; // White default
    }

    async loadImage(path) {
        const file = Utils.getFile(this.zip, path);
        if (!file) return null;
        const u8 = await file.async("uint8array");
        const b64 = Utils.b64(u8);
        const ext = path.split('.').pop().toLowerCase();
        const mimeMap = { png: "image/png", jpg: "image/jpeg", jpeg: "image/jpeg", gif: "image/gif", svg: "image/svg+xml", bmp: "image/bmp", webp: "image/webp" };
        const mime = mimeMap[ext] || "image/png";
        return `data:${mime};base64,${b64}`;
    }

    extractColor(node) {
        if (!node) return null;
        let colorHex = null;
        const srgb = Utils.find(node, "srgbClr");
        const scheme = Utils.find(node, "schemeClr");
        const sys = Utils.find(node, "sysClr");

        if (srgb) colorHex = "#" + srgb.getAttribute("val");
        else if (scheme) {
            const val = scheme.getAttribute("val");
            colorHex = this.themeColors[val];
            if (!colorHex) {
                if (val === "bg1" || val === "lt1") colorHex = "#ffffff";
                else if (val === "tx1" || val === "dk1") colorHex = "#000000";
                else colorHex = "#666666";
            }
        } else if (sys) colorHex = "#" + sys.getAttribute("lastClr");

        if (!colorHex) return null;

        const sourceNode = srgb || scheme || sys;
        if (sourceNode) {
            const lumMod = Utils.find(sourceNode, "lumMod")?.getAttribute("val");
            const lumOff = Utils.find(sourceNode, "lumOff")?.getAttribute("val");
            if (lumMod || lumOff) colorHex = Utils.applyLum(colorHex, lumMod, lumOff);
        }
        return colorHex;
    }

    // --- Extract text from SmartArt/Chart external XML files ---
    async extractExternalText(graphicData, rels, sourcePath) {
        const uri = graphicData.getAttribute("uri") || "";
        const texts = [];

        // SmartArt (diagram)
        if (uri.includes("diagram")) {
            const relIds = Utils.find(graphicData, "relIds");
            if (relIds) {
                const dmId = relIds.getAttribute("r:dm");
                if (dmId && rels[dmId]) {
                    const dmPath = this.resolvePath(sourcePath, rels[dmId]);
                    const dmXml = await this.readXml(dmPath);
                    if (dmXml) {
                        const tNodes = Utils.findAll(dmXml.documentElement, "t");
                        for (const t of tNodes) {
                            const txt = t.textContent.trim();
                            if (txt) texts.push(txt);
                        }
                    }
                }
            }
        }

        // Chart
        if (uri.includes("chart")) {
            for (let ci = 0; ci < graphicData.children.length; ci++) {
                const ch = graphicData.children[ci];
                if (ch.localName === "chart") {
                    const rId = ch.getAttribute("r:id");
                    if (rId && rels[rId]) {
                        const chartPath = this.resolvePath(sourcePath, rels[rId]);
                        const chartXml = await this.readXml(chartPath);
                        if (chartXml) {
                            const tNodes = Utils.findAll(chartXml.documentElement, "t");
                            for (const t of tNodes) {
                                const txt = t.textContent.trim();
                                if (txt) texts.push(txt);
                            }
                        }
                    }
                }
            }
        }

        return texts;
    }
}

/** App Controller */
const App = {
    parser: new PptxParser(),
    curr: 0, total: 0, zoom: 1.0,

    init() {
        //document.getElementById('file-input').onchange = e => { if (e.target.files[0]) App.load(e.target.files[0]); };
        document.getElementById('btn-prev').onclick = () => App.go(-1);
        document.getElementById('btn-next').onclick = () => App.go(1);
        document.getElementById('btn-zoom-in').onclick = () => App.z(0.1);
        document.getElementById('btn-zoom-out').onclick = () => App.z(-0.1);
        document.getElementById('btn-zoom-reset').onclick = () => { App.zoom = 1.0; App.render(); };
        document.getElementById('btn-export-pdf').onclick = () => App.exportPDF();
        document.getElementById('btn-export-images').onclick = () => App.exportImages();
        window.onresize = () => App.fit();
    },

    async load(file) {
        const validation = Utils.validatePptxFile(file);
        if (!validation.valid) {
            alert(validation.error);
            return;
        }

        document.getElementById('loading').style.display = 'block';
        //document.getElementById('file-name').textContent = file.name;
        try {
            App.total = await App.parser.load(file);
            App.curr = 0;
            if (App.total > 0) {
                await App.draw(); App.fit();
                document.getElementById('btn-export-pdf').disabled = false;
                document.getElementById('btn-export-images').disabled = false;
            }
            //else alert("ă‚ąă©ă‚¤ă‰ăŚč¦‹ă¤ă‹ă‚Šăľă›ă‚“ă§ă—ăźă€‚");
        } catch (e) { console.error(e); /*alert("čŞ­ăżčľĽăżă‚¨ă©ăĽ: " + e.message);*/ }
        document.getElementById('loading').style.display = 'none';
    },

    async go(d) {
        const n = App.curr + d;
        if (n >= 0 && n < App.total) { App.curr = n; await App.draw(); }
    },

    async draw() {
        const data = await App.parser.getSlideData(App.curr);
        document.getElementById('page-num').textContent = `${App.curr + 1} / ${App.total}`;
        document.getElementById('btn-prev').disabled = App.curr === 0;
        document.getElementById('btn-next').disabled = App.curr === App.total - 1;

        const vp = document.getElementById('slides-viewport');
        vp.innerHTML = '';

        const frame = document.createElement('div');
        frame.className = 'slide-frame';
        frame.style.width = data.size.width + 'px';
        frame.style.height = data.size.height + 'px';

        if (data.background.type === 'image') {
            frame.style.backgroundImage = `url(${data.background.value})`;
            frame.style.backgroundSize = 'cover';
        } else {
            frame.style.backgroundColor = data.background.value;
        }

        data.shapes.forEach(s => {
            let zeroSizeRescue = false;
            if (s.box.w === 0 && s.box.h === 0) {
                if (s.paragraphs && s.paragraphs.some(p => p.runs.some(r => r.text && r.text.trim()))) {
                    s.box.x = 0;
                    s.box.y = 0;
                    s.box.w = 200;
                    s.box.h = 50;
                    zeroSizeRescue = true;
                } else {
                    return;
                }
            }

            const el = document.createElement(s.type === 'image' ? 'img' : 'div');
            el.className = 'shape';
            el.style.left = s.box.x + 'px';
            el.style.top = s.box.y + 'px';
            el.style.width = s.box.w + 'px';
            el.style.height = s.box.h + 'px';
            if (s.box.rot) el.style.transform = `rotate(${s.box.rot}deg)`;
            if (zeroSizeRescue) el.style.border = '2px solid red';

            if (s.type === 'image') {
                el.src = s.src;
            } else if (s.type === 'table') {
                // Table Rendering
                const table = document.createElement('table');
                table.className = 'ppt-table';

                // ColGroup
                const colGroup = document.createElement('colgroup');
                s.cols.forEach(w => {
                    const col = document.createElement('col');
                    col.style.width = w + 'px';
                    colGroup.appendChild(col);
                });
                table.appendChild(colGroup);

                // Body
                const tbody = document.createElement('tbody');
                s.rows.forEach(r => {
                    const tr = document.createElement('tr');
                    tr.style.height = r.height + 'px';
                    r.cells.forEach(c => {
                        const td = document.createElement('td');
                        td.className = 'ppt-td';
                        if (c.colSpan > 1) td.colSpan = c.colSpan;
                        if (c.rowSpan > 1) td.rowSpan = c.rowSpan;
                        if (c.bgColor) td.style.backgroundColor = c.bgColor;

                        // Text Content inside Cell
                        if (c.text) {
                            let jc = 'flex-start';
                            if (c.text.vAlign === 'center') jc = 'center';
                            else if (c.text.vAlign === 'bottom') jc = 'flex-end';
                            const wrapper = document.createElement('div');
                            wrapper.style.display = 'flex';
                            wrapper.style.flexDirection = 'column';
                            wrapper.style.justifyContent = jc;
                            wrapper.style.height = '100%';
                            wrapper.style.padding = `${c.text.pad.t}px ${c.text.pad.r}px ${c.text.pad.b}px ${c.text.pad.l}px`;

                            c.text.paragraphs.forEach(p => App.renderParagraph(wrapper, p));
                            td.appendChild(wrapper);
                        }
                        tr.appendChild(td);
                    });
                    tbody.appendChild(tr);
                });
                table.appendChild(tbody);
                el.appendChild(table);

            } else {
                // Normal Shape / Text
                if (s.bgColor) el.style.backgroundColor = s.bgColor;
                const cont = document.createElement('div');
                cont.className = 'shape-content';

                let jc = 'flex-start';
                if (s.vAlign === 'center') jc = 'center';
                else if (s.vAlign === 'bottom') jc = 'flex-end';
                cont.style.justifyContent = jc;
                if (s.pad) cont.style.padding = `${s.pad.t}px ${s.pad.r}px ${s.pad.b}px ${s.pad.l}px`;

                s.paragraphs.forEach(p => App.renderParagraph(cont, p));
                el.appendChild(cont);
            }
            frame.appendChild(el);
        });

        vp.appendChild(frame);

        // Render SmartArt/Chart supplementary text area
        if (data.supplementaryTexts && data.supplementaryTexts.length > 0) {
            const suppArea = document.createElement('div');
            suppArea.className = 'supplementary-area';
            suppArea.style.width = data.size.width + 'px';

            const title = document.createElement('div');
            title.className = 'supplementary-title';
            title.textContent = 'SmartArt/Chart Text';
            suppArea.appendChild(title);

            data.supplementaryTexts.forEach(item => {
                const sourceLabel = document.createElement('div');
                sourceLabel.className = 'supplementary-source';
                sourceLabel.textContent = `[${item.source}]`;
                suppArea.appendChild(sourceLabel);

                item.texts.forEach(t => {
                    const textEl = document.createElement('div');
                    textEl.className = 'supplementary-text';
                    textEl.textContent = t;
                    suppArea.appendChild(textEl);
                });
            });

            vp.appendChild(suppArea);
        }

        App.renderZoom();
    },

    renderParagraph(container, p) {
        const pEl = document.createElement('div');
        pEl.className = 'para';
        pEl.style.textAlign = p.align === 'center' ? 'center' : p.align === 'right' ? 'right' : 'left';
        if (p.marL) pEl.style.marginLeft = `${p.marL}px`;
        if (p.indent) pEl.style.textIndent = `${p.indent}px`;

        p.runs.forEach(r => {
            if (r.text === '\n') pEl.appendChild(document.createElement('br'));
            else if (r.link) {
                const a = document.createElement('a');
                a.textContent = r.text;
                Object.assign(a.style, r.style);
                a.href = r.link;
                a.target = '_blank';
                a.rel = 'noopener noreferrer';
                a.style.textDecoration = 'underline';
                a.style.cursor = 'pointer';
                pEl.appendChild(a);
            }
            else {
                const span = document.createElement('span');
                span.textContent = r.text;
                Object.assign(span.style, r.style);
                pEl.appendChild(span);
            }
        });
        container.appendChild(pEl);
    },

    z(d) { App.zoom = Math.max(0.1, App.zoom + d); App.renderZoom(); },
    fit() {
        const c = document.getElementById('container');
        const s = App.parser.slideSize;
        if (!s.width) return;
        App.zoom = Math.min((c.clientWidth - 80) / s.width, (c.clientHeight - 80) / s.height);
        App.renderZoom();
    },
    renderZoom() {
        const vp = document.getElementById('slides-viewport');
        vp.style.transform = `scale(${App.zoom})`;
        document.getElementById('btn-zoom-reset').textContent = Math.round(App.zoom * 100) + '%';
    },

    async captureSlide(index) {
        const savedCurr = App.curr;
        const savedZoom = App.zoom;
        App.curr = index;
        App.zoom = 1.0;
        await App.draw();

        const vp = document.getElementById('slides-viewport');
        vp.style.transform = 'scale(1)';

        const frame = vp.querySelector('.slide-frame');
        const canvas = await html2canvas(frame, {
            scale: 2,
            useCORS: true,
            backgroundColor: null
        });

        App.curr = savedCurr;
        App.zoom = savedZoom;
        vp.style.transform = `scale(${savedZoom})`;
        return canvas;
    },

    async exportPDF() {
        if (App.total === 0) return;
        const loading = document.getElementById('loading');
        loading.style.display = 'block';
        loading.textContent = 'Loading­...';

        try {
            if (!window.jspdf) throw new Error('jsPDF library failed to load. Check your internet connection and try again.');
            const { jsPDF } = window.jspdf;
            const sw = App.parser.slideSize.width;
            const sh = App.parser.slideSize.height;
            const orientation = sw >= sh ? 'landscape' : 'portrait';
            const pdf = new jsPDF({ orientation, unit: 'px', format: [sw, sh] });

            for (let i = 0; i < App.total; i++) {
                loading.textContent = `Loading­... (${i + 1}/${App.total})`;
                if (i > 0) pdf.addPage([sw, sh], orientation);
                const canvas = await App.captureSlide(i);
                const imgData = canvas.toDataURL('image/jpeg', 0.92);
                pdf.addImage(imgData, 'JPEG', 0, 0, sw, sh);
            }

            pdf.save('slides.pdf');
        } catch (e) {
            console.error(e);
            alert('PDFä˝śćă‚¨ă©ăĽ: ' + e.message);
        }

        await App.draw();
        App.renderZoom();
        loading.style.display = 'none';
        loading.textContent = 'č§Łćžä¸­...';
    },

    async exportImages() {
        if (App.total === 0) return;
        const loading = document.getElementById('loading');
        loading.style.display = 'block';
        loading.textContent = 'Loading­...';

        try {
            const zip = new JSZip();
            for (let i = 0; i < App.total; i++) {
                loading.textContent = `Loading... (${i + 1}/${App.total})`;
                const canvas = await App.captureSlide(i);
                const blob = await new Promise(resolve => canvas.toBlob(resolve, 'image/png'));
                zip.file(`slide_${String(i + 1).padStart(3, '0')}.png`, blob);
            }

            loading.textContent = 'Loading­...';
            const content = await zip.generateAsync({ type: 'blob' });
            const a = document.createElement('a');
            a.href = URL.createObjectURL(content);
            a.download = 'slides.zip';
            a.click();
            URL.revokeObjectURL(a.href);
        } catch (e) {
            console.error(e);
            //alert('ç”»ĺŹä˝śćă‚¨ă©ăĽ: ' + e.message);
        }

        await App.draw();
        App.renderZoom();
        loading.style.display = 'none';
        loading.textContent = '­...';
    },

    render() {
        App.renderZoom();
    }
};

App.init();
